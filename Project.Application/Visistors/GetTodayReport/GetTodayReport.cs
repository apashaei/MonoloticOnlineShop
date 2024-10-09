using MongoDB.Driver;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Visitors.visitor;

namespace Project.Application.Visistors.GetTodayReport
{
    public class GetTodayReportService : IGetTodayReportService
    {

        private readonly IMongoDataBaseContext<Visitor> _mongoDataBaseContext;
        private IMongoCollection<Visitor> _collection;

        public GetTodayReportService(IMongoDataBaseContext<Visitor> mongoDataBaseContext)
        {
            _mongoDataBaseContext = mongoDataBaseContext;
            _collection = _mongoDataBaseContext.GetCollection();
        }
        public ResultTodayReportDto Execute()
        {
            DateTime Start = DateTime.Now.Date;
            DateTime End = DateTime.Now.AddDays(1);

            
            DateTime startMonth = DateTime.Now.AddDays(-30);
            DateTime endMonth = DateTime.Now.AddDays(1);


            var TodayPageViewCount = _collection.AsQueryable().Where(p => p.Time >= Start && p.Time < End).LongCount();
            var TodayVisitors = _collection.AsQueryable().Where(p => p.Time >= Start && p.Time < End).GroupBy(p => p.VisitorId).LongCount();
            var todayViewsPerVisitor = TodayVisitors==0? 0:TodayPageViewCount / TodayVisitors;
            var AllPageViewCounts = _collection.AsQueryable().LongCount();
            var AllVisitorCount = _collection.AsQueryable().GroupBy(p => p.VisitorId).LongCount();
            var TodayPageViewList = _collection.AsQueryable().Where(p=>p.Time>= Start && p.Time < End).Select(p=> new {p.Time}).ToList();
            var MonthPageViewList = _collection.AsQueryable().Where(p=>p.Time>= startMonth && p.Time <= endMonth).Select(p=> new {p.Time}).ToList();
            
            VisitCount visitPerHour = new VisitCount()
            {
                Display = new string[24],
                Value = new int[24]
            };

            VisitCount visitPerDay = new VisitCount()
            {
                
                Display = new string[31],
                Value = new int[31]
            };

            for (int i = 0; i <= 30; i++)
            {
                var currentDay = DateTime.Now.AddDays(i*(-1));

                visitPerDay.Display[i] = $"D-{i}";
                visitPerDay.Value[i]= MonthPageViewList.AsQueryable().Where(p=>p.Time.Date==currentDay.Date).Count();

            }

            for (int i = 0; i <= 23; i++)
            {


                visitPerHour.Display[i] = $"h-{i}";
                visitPerHour.Value[i] = TodayPageViewList.AsQueryable().Where(p => p.Time.Hour == i).Count();

            }

            var Visitors = _collection.AsQueryable().OrderByDescending(p=>p.Time).Select(p=> 
            
            new LastVisitorsDto
            {
                Browser = p.Browser.Family,
                CurrentLink = p.CurrentLink,
                Ip = p.IP,
                Id = p.Id,
                IsSpider = p.Device.IsSpider,
                Operator = p.OperationSystem.Family,
                ReferrerLink = p.ReferrerLink,
                Time = p.Time.ToString()
            }
            
            ).Take(10).ToList();

            return new ResultTodayReportDto
            {
                Generalstate = new GeneralstateDto
                {
                    TotalVisitors = AllVisitorCount,
                    TotalPageViews = AllPageViewCounts,
                    PageViewsPerVisit = AllPageViewCounts / AllVisitorCount,
                    visitPerDayCount = visitPerDay

                },
                Today = new TodayDto
                {
                    PageViews = TodayPageViewCount,
                    Visitors = TodayVisitors,
                    ViewsPerVisitor = todayViewsPerVisitor,
                    VisitCount = visitPerHour
                },
                visitorsDto = Visitors

            };


        }
    }
}
