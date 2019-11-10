using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BridegeManagement.Models;
using AutoMapper;
using BridegeManagement.IRepository;
using BridegeManagement.ViewModels.BridgeViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using BridegeManagement.IControllerService;
using System.IO;
using OfficeOpenXml;
using BridegeManagement.ViewModels.HomeViewModels;
using BridegeManagement.ViewModels.ComponentViewModels;

namespace BridegeManagement.Controllers
{

    public static class StaticDistinctBy
    {
        public static IEnumerable<T> DistinctBy<T>(this IEnumerable<T> list, Func<T, object> propertySelector)
        {
            return list.GroupBy(propertySelector).Select(x => x.First());
        }

        //public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        //{
        //    HashSet<TKey> seenKeys = new HashSet<TKey>();
        //    foreach (TSource element in source)
        //    {
        //        if (seenKeys.Add(keySelector(element)))
        //        {
        //            yield return element;
        //        }
        //    }
        //}
    }

    public class HomeController : Controller
    {



        private readonly IBridgeRepository _bridgeRepository;
        private readonly IComponentRepository _componentRepository;
        private readonly IDamageRepository _damageRepository;
        private readonly IWebFileService _webFileService;
        private readonly IMapper _mapper;

        public HomeController(
            IMapper mapper
            , IWebFileService webFileService
            , IBridgeRepository bridgeRepository
            , IComponentRepository componentRepository
            , IDamageRepository damageRepository)
        {
            _mapper = mapper;
            _webFileService = webFileService;
            _bridgeRepository = bridgeRepository;
            _componentRepository = componentRepository;
            _damageRepository = damageRepository;
        }

        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        /// 名称是否唯一
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        //public bool IsNameUnique(string Name)
        //{

        //    var cnt = _bridgeRepository.EntityItems.Where(x => x.Name == Name);
        //    if (cnt.Any())
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Main()
        {
            //var k = _damageRepository.GetQuery(x => x.Num == 5).Include(x=>x.Component).Where(x=>x.Component.Name== "上部承重构件");

            int testSubType = 23;
            //var testDateTime = new DateTime(1980, 1, 1);

            //27个病害
            var damageArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25, 26, 27, 999 };
            int[] damageCounts = new int[27];
            for(int i=0;i< damageArray.Count(); i++)
            {
                damageCounts[i] = 0;
            }

            var k = (from p in _bridgeRepository.EntityItems
                     join q in _componentRepository.EntityItems
                     on p.Id equals q.BridgeId
                     join r in _damageRepository.EntityItems
                     on q.Id equals r.ComponentId
                     //where p.Grade==3
                     where p.SubType == testSubType
                     //where p.BuildYear < testDateTime
                     select new CombineViewModel
                     {
                         BridgeName = p.Name,
                         ComponentName = q.Name,
                         DamageNum = r.Num,
                         Owner=p.Owner,                         
                     }).DistinctBy(p=>p.BridgeName);

            for (int i = 0; i < damageArray.Count(); i++)
            {
                damageCounts[i] = (from p in _bridgeRepository.EntityItems
                                   join q in _componentRepository.EntityItems
                                   on p.Id equals q.BridgeId
                                   join r in _damageRepository.EntityItems
                                   on q.Id equals r.ComponentId
                                   where p.SubType == testSubType 
                                   //where p.BuildYear< testDateTime
                                   && r.Num == damageArray[i]
                                   select new CombineViewModel
                                   {
                                       BridgeName = p.Name,
                                       ComponentName = q.Name,
                                       DamageNum = r.Num
                                   }).Count();
            }

            var v = new MainViewModel
            {
                CombineViewModels = k,
                DamageArray=damageArray,
                DamageCounts= damageCounts,
            };
            return View(v);
        }

        public IActionResult BridgeCounts()
        {
            const int statCounts = 6;

            int[] bridgeCountsArray = new int[statCounts];

            DateTime[][] dateTimeArray=new DateTime[statCounts][];

            dateTimeArray[0] = new DateTime[] { new DateTime(1911, 1, 1), new DateTime(1959, 12, 31) };
            dateTimeArray[1] = new DateTime[] { new DateTime(1960, 1, 1), new DateTime(1979, 12, 31) };
            dateTimeArray[2] = new DateTime[] { new DateTime(1980, 1, 1), new DateTime(1999, 12, 31) };
            dateTimeArray[3] = new DateTime[] { new DateTime(2000, 1, 1), new DateTime(2009, 12, 31) };
            dateTimeArray[4] = new DateTime[] { new DateTime(2010, 1, 1), new DateTime(2019, 12, 31) };
            dateTimeArray[5] = new DateTime[] { new DateTime(2019, 12, 31), new DateTime(9999, 12, 31) };


            for (int i=0;i< statCounts; i++)
            {
                bridgeCountsArray[i] = (from p in _bridgeRepository.EntityItems
                                        where p.BuildYear >= dateTimeArray[i][0]
                                        && p.BuildYear <= dateTimeArray[i][1]
                                        select p
                     ).Count();
            }

            var bridgeCountsViewModel = new BridgeCountsViewModel
            {
                BridgeCountsArray = bridgeCountsArray
            };
            return View(bridgeCountsViewModel);
        }

        //[HttpGet]
        //public IActionResult ExcelImportBridge()
        //{
        //    ViewData["Title"] = "Excel导入桥梁";
        //    return View(new ExcelImportBridgeViewModel { StatusMessage = StatusMessage });
        //}

        //[HttpPost]
        //public async Task<IActionResult> ExcelImportBridge([FromServices]IHostingEnvironment env, IFormFile ExcelImport)
        //{

        //    var sheetName = "桥梁";

        //    CreateBridgeViewModel viewModel;
        //    Bridge dbEntity;
        //    try
        //    {
        //        FileInfo file = await _webFileService.GetFileInfo(env, ExcelImport);
        //        List<int> failRows = new List<int>();    //excel中写入失败的行数

        //        using (ExcelPackage package = new ExcelPackage(file))
        //        {
        //            ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetName];
        //            int rowCount = 1;// worksheet.Dimension.Rows;   //worksheet.Dimension.Rows指的是所有列中最大行
        //            //首行：表头不导入
        //            bool rowCur = true;    //行游标指示器
        //                                   //rowCur=false表示到达行尾
        //                                   //计算行数
        //            while (rowCur)
        //            {
        //                try
        //                {
        //                    //跳过表头
        //                    if (string.IsNullOrEmpty(worksheet.Cells[rowCount + 1, 1].Value.ToString()))
        //                    {
        //                        rowCur = false;
        //                    }
        //                }
        //                catch (Exception)   //读取异常则终止
        //                {
        //                    rowCur = false;
        //                }

        //                if (rowCur)
        //                {
        //                    rowCount++;
        //                }
        //            }

        //            bool validationResult = false;
        //            int row = 2;    //excel中行指针
        //            //行号不为空，则继续添加
        //            //while (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value.ToString()))
        //            for (row = 2; row <= rowCount; row++)
        //            {
        //                //
        //                //1、处理excel数据导入;
        //                //2、验证"视图模型";
        //                //3、验证业务模型;
        //                try
        //                {
        //                    viewModel = new CreateBridgeViewModel
        //                    {
        //                        //Title = worksheet.Cells[row, 2].Value?.ToString() ?? string.Empty,
        //                        //OptionA = worksheet.Cells[row, 3].Value?.ToString() ?? string.Empty,
        //                        //OptionB = worksheet.Cells[row, 4].Value?.ToString() ?? string.Empty,
        //                        //OptionC = worksheet.Cells[row, 5].Value?.ToString() ?? string.Empty,
        //                        //OptionD = worksheet.Cells[row, 6].Value?.ToString() ?? string.Empty,
        //                        //Answer = worksheet.Cells[row, 7].Value?.ToString() ?? string.Empty,
        //                        //Hint = worksheet.Cells[row, 8].Value?.ToString() ?? string.Empty,
        //                        //Analysis = worksheet.Cells[row, 9].Value?.ToString() ?? string.Empty,
        //                        //QuestionGroup = (QuestionGroup)int.Parse(worksheet.Cells[row, 10]?.Value.ToString() ?? string.Empty),   //TODO：异常处理
        //                        //Index = int.Parse(worksheet.Cells[row, 11]?.Value.ToString() ?? string.Empty),
        //                        //CreateUser = user.StaffName,
        //                        //CreateTime = DateTime.Now,

        //                        Name = worksheet.Cells[row, FindCol(worksheet, "名称")].Value?.ToString() ?? string.Empty,
        //                        PierNum= worksheet.Cells[row, FindCol(worksheet, "桩号")].Value?.ToString() ?? string.Empty,
        //                        RouteGrade= int.Parse(worksheet.Cells[row, FindCol(worksheet, "路线等级")].Value?.ToString() ?? string.Empty),

        //                    };

        //                    //若excel数据导入没有问题（如格式等原因报错）
        //                    validationResult = TryValidateModel(viewModel) && IsNameUnique(viewModel.Name);    //先验证单个"视图模型"

        //                    if (validationResult == true)
        //                    {
        //                        dbEntity = _mapper.Map<Bridge>(viewModel);

        //                        //再验证业务模型
        //                        TryValidateModel(dbEntity);
        //                        if (!ModelState.IsValid)
        //                        {
        //                            //业务模型出错
        //                            failRows.Add(row);
        //                            continue;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        //"视图模型"出错
        //                        failRows.Add(row);
        //                        continue;
        //                    }
        //                }
        //                catch (Exception)
        //                {
        //                    //Excel数据读取异常（一般为格式输入问题）
        //                    failRows.Add(row);
        //                    continue;
        //                }

        //                //写入数据库
        //                try
        //                {
        //                    await _bridgeRepository.CreateAsync(dbEntity);

        //                }
        //                catch (Exception)
        //                {
        //                    failRows.Add(row);
        //                }

        //                //row = row + 1;   //同while 语句配套
        //            }

        //            if (failRows.Count == 0)
        //            {
        //                StatusMessage = "导入数据成功";
        //            }
        //            else if (failRows.Count == rowCount - 1)  //-1的原因是因为表头
        //            {
        //                StatusMessage = "错误:导入数据失败";
        //            }
        //            else
        //            {
        //                string failRowsString = "";
        //                foreach (var i in failRows)
        //                {
        //                    failRowsString = failRowsString + " " + i.ToString();
        //                }
        //                StatusMessage = $"错误:部分数据导入成功,其中第{failRowsString}行数据导入失败";
        //            }
        //        }
        //        //显示导入结果
        //        return View(new ExcelImportBridgeViewModel { StatusMessage = StatusMessage });
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //        //return RedirectToAction(nameof(HomeController.Index), "Home");
        //    }

        //    //
        //    //TODO：数据读取有效性，上下界校验等未作检查
        //    int FindCol(ExcelWorksheet worksheet, string Title)
        //    {
        //        int Ubound = 1000;    //列上界
        //        for(int i=2;i<Ubound;i++)
        //        {
        //            if((worksheet.Cells[1, i].Value?.ToString() ?? string.Empty)==Title)
        //            {
        //                return i;
        //            }
        //        }
        //        return 0;    //查找不到则返回0
        //    }

        //}
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
