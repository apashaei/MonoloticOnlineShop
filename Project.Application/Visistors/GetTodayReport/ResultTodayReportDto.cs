namespace Project.Application.Visistors.GetTodayReport
{
    public class ResultTodayReportDto
    {
        public GeneralstateDto Generalstate { get; set; }
        public TodayDto Today { get; set; }
        public List<LastVisitorsDto> visitorsDto { get; set; }
    }
}
