using AysanRaf.NakliyeMontaj.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace AysanRaf.NakliyeMontaj.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlannedRealizedComparisonExcellController : Controller
    {
        private readonly PlannedRealizedComparisonExcellService _excelExportService;

        
        public PlannedRealizedComparisonExcellController(PlannedRealizedComparisonExcellService excelExportService)
        {
            _excelExportService = excelExportService;
        }



        [HttpGet("comparison-export-to-excel/{salesOfferNumber}")]
        public IActionResult ExportToExcel(string salesOfferNumber)
        { // İsteği gönderen kaynağa (origin) izin veren CORS başlıklarını ayarla
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://192.168.1.32:8010");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            // ExcelExportService sınıfını kullanarak Excel dosyasını oluşturun
            var excelFileStream = _excelExportService.ExportToExcel(salesOfferNumber);

            // MemoryStream'den Excel dosyasını döndürün
            return File(excelFileStream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "exported_file.xlsx");
        }
    }
}
