using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application._ٍExceptions
{
    public class NotFoundException:Exception
    {
        public NotFoundException(string EntityName, object Key):
            base($"انتیتی با نام {EntityName} با کلید {Key} پیدا نشد.")
        {
            
        }
    }
}
