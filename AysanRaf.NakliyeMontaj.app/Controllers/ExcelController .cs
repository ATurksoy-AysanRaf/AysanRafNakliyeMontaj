using AysanRaf.NakliyeMontaj.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace AysanRaf.NakliyeMontaj.app.Controllers
{
    public class ExcelController : Controller
    {
        private readonly ExcelExportService _excelExportService;

        public ExcelController(ExcelExportService excelExportService)
        {
            _excelExportService = excelExportService;
        }

        [HttpGet("export")]
        public IActionResult ExportToExcel()
        {
            var memoryStream = _excelExportService.ExportToExcel();

            // MemoryStream'deki veriyi bir byte dizisine dönüştürün
            var content = memoryStream.ToArray();

            // Response olarak Excel dosyasını döndürün
            return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "example.xlsx");
        }
    }
}
