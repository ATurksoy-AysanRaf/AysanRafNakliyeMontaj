using AutoMapper;
using AysanRaf.NakliyeMontaj.Business.Services;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;

namespace AysanRaf.NakliyeMontaj.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            // MemoryStream'den Excel dosyasını döndürün
            return File(excelFileStream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "exported_file.xlsx");
        }



        
    }
}
