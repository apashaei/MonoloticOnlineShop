using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.CatalogitemImage.GetCatalogItemIageSrcService
{
    public interface IGetCatalogItemImageSrc
    {
        string Execute(string src);
    }
    public class GetCatalogItemImageSrc : IGetCatalogItemImageSrc
    {
        public string Execute(string src)
        {
            return "http://localhost:5127/" + src.Replace("\\","//");
        }
    }
}
