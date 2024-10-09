using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RestSharp;

namespace Project.Infrastructure.ExternalApi.ImageService
{
    public class UploadImageService : IUploadImageService
    {
        public List<string> Upload(List<IFormFile> files)
        {

            var options = new RestClientOptions("https://localhost:7067")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/images?apiKey=mysecretkey", Method.Get);
            request.AlwaysMultipartFormData = true;
            foreach (var file in files)
            {
                byte[] data;
                using (var ms = new MemoryStream())
                {
                    file.CopyToAsync(ms);
                    data = ms.ToArray();
                }
                request.AddFile(file.FileName, data, file.FileName, file.ContentType);
            };
           
            RestResponse response = client.Execute(request);
            UploadDto upload = JsonConvert.DeserializeObject<UploadDto>(response.Content);
            return upload.FileNameAddress;

        }
    }
}
