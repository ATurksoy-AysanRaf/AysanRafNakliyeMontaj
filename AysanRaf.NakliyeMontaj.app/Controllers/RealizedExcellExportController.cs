using AysanRaf.NakliyeMontaj.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace AysanRaf.NakliyeMontaj.app.Controllers
{
    public class RealizedExcellExportController : Controller
    {
        private readonly RealizedExcellExportService _excelExportService;

        public RealizedExcellExportController(RealizedExcellExportService excelExportService)
        {
            _excelExportService = excelExportService;
        }



        [HttpGet("realized-export-to-excel/{Id}")]
        public IActionResult ExportToExcel(Guid Id)
        {
            // ExcelExportService sınıfını kullanarak Excel dosyasını oluşturun
            var excelFileStream = _excelExportService.ExportToExcel(Id);

            // MemoryStream'den Excel dosyasını döndürün
            return File(excelFileStream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "exported_file.xlsx");
        }

    }
}
