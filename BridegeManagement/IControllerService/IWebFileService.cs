using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.IControllerService
{
    public interface IWebFileService
    {
        Task<FileInfo> GetFileInfo(IHostingEnvironment env, IFormFile ExcelImport);
    }
}
