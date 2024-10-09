namespace Project.Application.Visistors.GetTodayReport
{
    public class LastVisitorsDto
    {
        public string Ip { get; set; }
        public string CurrentLink { get; set; }
        public string ReferrerLink { get; set; }
        public string Browser { get; set; }
        public string Operator { get; set; }
        public bool IsSpider { get; set; }
        public string Time { get; set; }
        public string Id { get; set; }     
    }
}
