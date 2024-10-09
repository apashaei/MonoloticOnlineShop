using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Visistors.SaveVisitorInfo
{
    public interface ISaveVisitorInfoService
    {
        void Excute(VisitorDto visitorDto);
    }
}
