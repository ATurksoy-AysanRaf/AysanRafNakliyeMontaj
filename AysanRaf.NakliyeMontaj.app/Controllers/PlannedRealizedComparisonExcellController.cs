using AysanRaf.NakliyeMontaj.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace AysanRaf.NakliyeMontaj.app.Controllers
{
    public class PlannedRealizedComparisonExcellController : Controller
    {
        private readonly PlannedRealizedComparisonExcellService _excelExportService;

       
        public PlannedRealizedComparisonExcellController(PlannedRealizedComparisonExcellService excelExportService)
        {
            _excelExportService = excelExportService;
        }



        [HttpGet("comparison-export-to-excel/{salesOfferNumber}")]
        public IActionResult ExportToExcel(string salesOfferNumber)
        {
            // ExcelExportService sınıfını kullanarak Excel dosyasını oluşturun
            var excelFileStream = _excelExportService.ExportToExcel(salesOfferNumber);

            // MemoryStream'den Excel dosyasını döndürün
            return File(excelFileStream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "exported_file.xlsx");
        }
    }
}
