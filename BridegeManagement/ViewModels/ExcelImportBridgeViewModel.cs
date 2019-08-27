using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace BridegeManagement.ViewModels.BridgeViewModels
{
    public class ExcelImportStrainMonitorViewModel
    {
        [Display(Name = "Excel导入")]
        [FileExtensions(Extensions = ".xlsx", ErrorMessage = "只允许上传xlsx后缀名文件")]
        public string ExcelImport { get; set; }

        public string StatusMessage { get; set; }
    }
}
