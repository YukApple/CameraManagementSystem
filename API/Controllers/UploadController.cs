using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("upload")]
    public class UploadController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage UploadFile(string id)
        {
            var httpContext = HttpContext.Current;
            var fileSavePath = "";
            //var newfolder = DateTime.Now.ToString("ddMMyyyyhhmmss");
            // Check for any uploaded file  
            if (httpContext.Request.Files.Count > 0)
            {
                //Loop through uploaded files  
                for (int i = 0; i < httpContext.Request.Files.Count; i++)
                {
                    HttpPostedFile httpPostedFile = httpContext.Request.Files[i];
                    if (httpPostedFile != null)
                    {
                        var folder = Path.Combine(ConfigurationManager.AppSettings["FtpFolder"], id);
                        if (!Directory.Exists(folder))
                            Directory.CreateDirectory(folder);
                        fileSavePath = Path.Combine(folder, httpPostedFile.FileName);
                        // Save the uploaded file  
                        httpPostedFile.SaveAs(fileSavePath);
                    }
                }
            }
            // Return status code  
            return Request.CreateResponse(HttpStatusCode.OK,fileSavePath);
        }

        [HttpGet]
        public Object DownloadFile(string filename)
        {
            var rootPath = ConfigurationManager.AppSettings["FtpFolder"];
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            var _file = filename.Split('/');
            filename = filename.Replace("/", "\\");
            var fullPathFile = Path.Combine(rootPath, filename);
            byte[] file = File.ReadAllBytes(fullPathFile);
            MemoryStream ms = new MemoryStream(file);
            response.Content = new ByteArrayContent(file);
            response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
            response.Content.Headers.ContentDisposition.FileName = _file[1];
            return response;
        }
    }
}
