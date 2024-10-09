using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace Project.Infrastructure.ExternalApi.ImageService
{
    public interface IUploadImageService
    {
        List<string> Upload(List<IFormFile> files); 
    }
}
