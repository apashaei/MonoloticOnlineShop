using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Visistors.GetTodayReport;

namespace Admin.EndPoint.Pages.Visitors
{
    [Authorize(Roles ="Admin")]
    public class IndexModel : PageModel
    {

        private readonly IGetTodayReportService _getTodayReportService;
        public ResultTodayReportDto resultTodayReportDto;

        public IndexModel(IGetTodayReportService getTodayReportService)
        {
            _getTodayReportService = getTodayReportService;
        }


        public void OnGet()
        {
            resultTodayReportDto = _getTodayReportService.Execute();
        }
    }
}
