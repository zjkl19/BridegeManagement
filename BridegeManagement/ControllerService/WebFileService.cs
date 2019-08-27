using BridegeManagement.IControllerService;
using BridegeManagement.IControllerService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.ControllerService
{
    public class WebFileService: IWebFileService
    {
        public async Task<FileInfo> GetFileInfo(IHostingEnvironment env, IFormFile ExcelImport)
        {
            string TempFolder = "Temp";    //临时文件夹名称
            string fileName;
            //先删除临时文件
            string pattern = "*.xlsx";
            string[] strFileName = Directory.GetFiles(Path.Combine(env.WebRootPath, TempFolder), pattern);
            foreach (var item in strFileName)
            {
                File.Delete(Path.Combine(env.WebRootPath, TempFolder, item));
            }

            //新建文件
            fileName = string.Empty;
            if (ExcelImport != null)
            {
                fileName = Path.Combine(TempFolder, Guid.NewGuid().ToString() + Path.GetExtension(ExcelImport.FileName));
            }

            FileInfo file = new FileInfo(Path.Combine(env.WebRootPath, fileName));
            using (var stream = new FileStream(Path.Combine(env.WebRootPath, fileName), FileMode.CreateNew))
            {
                await ExcelImport.CopyToAsync(stream);
                stream.Flush();
            }

            return file;
        }
    }
}
