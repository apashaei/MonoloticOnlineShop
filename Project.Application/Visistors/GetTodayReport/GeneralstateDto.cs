namespace Project.Application.Visistors.GetTodayReport
{
    public class GeneralstateDto
    {
        public long TotalPageViews { get; set; }
        public long TotalVisitors { get; set; }
        public float PageViewsPerVisit { get; set; }
        public VisitCount visitPerDayCount { get; set; }
    }
}
