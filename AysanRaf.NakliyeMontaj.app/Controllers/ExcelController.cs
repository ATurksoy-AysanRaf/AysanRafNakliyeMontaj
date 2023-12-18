using AutoMapper;
using AysanRaf.NakliyeMontaj.Business.Services;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;

namespace AysanRaf.NakliyeMontaj.app.Controllers
{
    public class ExcelController : Controller
    {
        private readonly ExcelExportService _excelExportService;

        public ExcelController(ExcelExportService excelExportService)
        {
            _excelExportService = excelExportService;
        }



        [HttpGet("planned-export-to-excel/{Id}")]
        public IActionResult ExportToExcel(Guid Id)
        {
            // ExcelExportService sınıfını kullanarak Excel dosyasını oluşturun
            var excelFileStream = _excelExportService.ExportToExcel(Id);

            // MemoryStream'den Excel dosyasını döndürün
            return File(excelFileStream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "exported_file.xlsx");
        }



        
    }
}
