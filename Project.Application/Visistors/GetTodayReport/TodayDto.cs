namespace Project.Application.Visistors.GetTodayReport
{
    public class TodayDto
    {
        public long PageViews { get; set; }
        public long Visitors { get; set; }
        public float ViewsPerVisitor { get; set; }
        public VisitCount VisitCount { get; set; }
    }
}
