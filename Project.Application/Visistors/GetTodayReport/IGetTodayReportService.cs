using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Visistors.GetTodayReport
{
    public interface IGetTodayReportService
    {
        ResultTodayReportDto Execute();
    }
}
