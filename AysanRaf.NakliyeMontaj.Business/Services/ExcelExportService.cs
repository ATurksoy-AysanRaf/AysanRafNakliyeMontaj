using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.Business.Services
{
    public class ExcelExportService
    {
        public MemoryStream ExportToExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // veya LicenseContext.Commercial

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Başlık ekleyin
                worksheet.Cells[1, 1].Value = "Header 1";
                worksheet.Cells[1, 2].Value = "Header 2";

                // Verileri ekleyin
                worksheet.Cells[2, 1].Value = "Data 1";
                worksheet.Cells[2, 2].Value = "Data 2";

                // Diğer verileri ekleyin
                // worksheet.Cells[3, 1].Value = ...

                // MemoryStream'e yazın
                var memoryStream = new MemoryStream();
                package.SaveAs(memoryStream);

                return memoryStream;
            }
        }
    }
}
