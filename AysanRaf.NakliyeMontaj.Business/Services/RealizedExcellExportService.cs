using Models;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.Business.Services
{
    public class RealizedExcellExportService
    {
        private readonly aysanrafpopsepdevelopment_2023_09_10_05_45Context _context;

        public RealizedExcellExportService(aysanrafpopsepdevelopment_2023_09_10_05_45Context dbContext)
        {
            _context = dbContext;
        }
        public MemoryStream ExportToExcel(Guid objectId)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // veya LicenseContext.Commercial

            // ID'ye göre nesne listesini al
            var objectList = _context.RealizedOfferForms.Where(obj => obj.Id == objectId).ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");



                int startRow = 1;
                int endRow = 2;
                int startColumn = 1;
                int endColumn = 5;

                // Belirtilen hücre aralığını birleştir
                worksheet.Cells[startRow, startColumn, endRow, endColumn].Merge = true;

                // Başlık metni
                worksheet.Cells[startRow, startColumn].Value = " GERÇEKLEŞEN ";

                // Başlık hücrenin stilini düzenleme
                worksheet.Cells[startRow, startColumn].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow, startColumn].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                worksheet.Cells[startRow, startColumn].Style.Font.Bold = true;









                // Başlık ekleyin
                worksheet.Cells[3, 1].Value = "Sipariş Numarası";
                worksheet.Cells[3, 2].Value = "Tarih";
                worksheet.Cells[3, 3].Value = "Kur";
                worksheet.Cells[3, 4].Value = "Müşteri";
                worksheet.Cells[3, 5].Value = "Şehir";

                worksheet.Cells[5, 1].Value = "Teklif Tonaj";
                worksheet.Cells[5, 2].Value = "Gerçek Tonaj";
                worksheet.Cells[5, 3].Value = "Günlük Tonaj";
                worksheet.Cells[5, 4].Value = "Gün Sayısı";
                worksheet.Cells[5, 5].Value = "Çalışan Sayısı";

                worksheet.Cells[7, 1].Value = "Günlük Yevmiye";
                worksheet.Cells[7, 2].Value = "Toplam Yevmiye";
                worksheet.Cells[7, 3].Value = "ISG Uzmanı";
                worksheet.Cells[7, 4].Value = "Saha Mühendisi";
                worksheet.Cells[7, 5].Value = "Toplam Yevmiye Tutarı";

                worksheet.Cells[9, 1].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[9, 2].Value = "Günlük Maliyeti";
                worksheet.Cells[9, 3].Value = "Aylık Maliyeti";
                worksheet.Cells[9, 4].Value = "Adeti";
                worksheet.Cells[9, 5].Value = "Toplam Maliyeti";

                worksheet.Cells[11, 1].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[11, 2].Value = "Günlük Maliyeti";
                worksheet.Cells[11, 3].Value = "Aylık Maliyeti";
                worksheet.Cells[11, 4].Value = "Adeti";
                worksheet.Cells[11, 5].Value = "Toplam Maliyeti";

                worksheet.Cells[13, 1].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[13, 2].Value = "Günlük Maliyeti";
                worksheet.Cells[13, 3].Value = "Aylık Maliyeti";
                worksheet.Cells[13, 4].Value = "Adeti";
                worksheet.Cells[13, 5].Value = "Toplam Maliyeti";

                worksheet.Cells[15, 1].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[15, 2].Value = "Günlük Maliyeti";
                worksheet.Cells[15, 3].Value = "Aylık Maliyeti";
                worksheet.Cells[15, 4].Value = "Adeti";
                worksheet.Cells[15, 5].Value = "Toplam Maliyeti";


                worksheet.Cells[17, 1].Value = "Ekipman Nakliye Maliyeti";
                worksheet.Cells[17, 2].Value = "Konaklama Birim Maliyeti";
                worksheet.Cells[17, 3].Value = "Konaklama Toplam Maliyeti";
                worksheet.Cells[17, 4].Value = "Yemek Birim Maliyeti";
                worksheet.Cells[17, 5].Value = "Yemek Toplam Maliyeti";


                worksheet.Cells[19, 1].Value = "Araba-Yakıt Maliyeti";
                worksheet.Cells[19, 2].Value = "Toplam Montaj Maliyeti(TL)";
                worksheet.Cells[19, 3].Value = "Toplam Montaj Maliyeti(USD)";

                worksheet.Cells[21, 1].Value = "Tır Sayısı";
                worksheet.Cells[21, 2].Value = "Tır Birim Maliyeti";
                worksheet.Cells[21, 3].Value = "Toplam Nakliye Maliyeti(TL)";
                worksheet.Cells[21, 4].Value = "Toplam Nakliye Maliyeti(USD)";

                // Verileri ekleyin
                for (int i = 0; i < objectList.Count; i++)
                {
                    worksheet.Cells[i + 4, 1].Value = objectList[i].SalesOfferNumber; // Property1 yerine gerçek özellik adını yazın
                    worksheet.Cells[i + 4, 2].Value = objectList[i].CreatedDate;
                    worksheet.Cells[i + 4, 2].Style.Numberformat.Format = "yyyy-mm-dd";
                    worksheet.Cells[i + 4, 3].Value = objectList[i].ExchangeRate;
                    worksheet.Cells[i + 4, 4].Value = objectList[i].CustomerName.ToUpper();
                    worksheet.Cells[i + 4, 5].Value = objectList[i].CustomerCity.ToUpper();

                    worksheet.Cells[i + 6, 1].Value = objectList[i].OfferTonnage;
                    worksheet.Cells[i + 6, 2].Value = objectList[i].ReallyTonnage;
                    worksheet.Cells[i + 6, 3].Value = objectList[i].DailyTonnage;

                    worksheet.Cells[i + 6, 4].Value = Math.Ceiling(objectList[i].NumberDays);

                    worksheet.Cells[i + 6, 5].Value = objectList[i].NumberEmployees;


                    worksheet.Cells[i + 8, 1].Value = objectList[i].DailyWageCost;
                    worksheet.Cells[i + 8, 2].Value = objectList[i].TotalWageAmount;
                    worksheet.Cells[i + 8, 3].Value = objectList[i].IsgexpertCost;
                    worksheet.Cells[i + 8, 4].Value = objectList[i].FieldEngineerCost;
                    worksheet.Cells[i + 8, 5].Value = objectList[i].WageTotalCost;


                    worksheet.Cells[i + 10, 1].Value = objectList[i].RentedEquipmentName1.ToUpper();
                    worksheet.Cells[i + 10, 2].Value = objectList[i].RentedEquipmentDailyCost1;
                    worksheet.Cells[i + 10, 3].Value = objectList[i].RentedEquipmentMonthlyCost1;
                    worksheet.Cells[i + 10, 4].Value = objectList[i].RentedEquipmentAmount1;
                    worksheet.Cells[i + 10, 5].Value = objectList[i].RentedEquipmentTotalCost1;


                    worksheet.Cells[i + 12, 1].Value = objectList[i].RentedEquipmentName2.ToUpper();
                    worksheet.Cells[i + 12, 2].Value = objectList[i].RentedEquipmentDailyCost2;
                    worksheet.Cells[i + 12, 2].Value = objectList[i].RentedEquipmentDailyCost2;
                    worksheet.Cells[i + 12, 3].Value = objectList[i].RentedEquipmentMonthlyCost2;
                    worksheet.Cells[i + 12, 4].Value = objectList[i].RentedEquipmentAmount2;
                    worksheet.Cells[i + 12, 5].Value = objectList[i].RentedEquipmentTotalCost2;


                    worksheet.Cells[i + 14, 1].Value = objectList[i].RentedEquipmentName3.ToUpper();
                    worksheet.Cells[i + 14, 2].Value = objectList[i].RentedEquipmentDailyCost3;
                    worksheet.Cells[i + 14, 3].Value = objectList[i].RentedEquipmentMonthlyCost3;
                    worksheet.Cells[i + 14, 4].Value = objectList[i].RentedEquipmentAmount3;
                    worksheet.Cells[i + 14, 5].Value = objectList[i].RentedEquipmentTotalCost3;


                    worksheet.Cells[i + 16, 1].Value = objectList[i].RentedEquipmentName4.ToUpper();
                    worksheet.Cells[i + 16, 2].Value = objectList[i].RentedEquipmentDailyCost4;
                    worksheet.Cells[i + 16, 3].Value = objectList[i].RentedEquipmentMonthlyCost4;
                    worksheet.Cells[i + 16, 4].Value = objectList[i].RentedEquipmentAmount4;
                    worksheet.Cells[i + 16, 5].Value = objectList[i].RentedEquipmentTotalCost4;



                    worksheet.Cells[i + 18, 1].Value = objectList[i].EquipmentShipmentCost;
                    worksheet.Cells[i + 18, 2].Value = objectList[i].AccommodationUnitPrice;
                    worksheet.Cells[i + 18, 3].Value = objectList[i].AccommodationTotalPrice;
                    worksheet.Cells[i + 18, 4].Value = objectList[i].StaffMealUnitPrice;
                    worksheet.Cells[i + 18, 5].Value = objectList[i].StaffMealTotalPrice;

                    worksheet.Cells[i + 20, 1].Value = objectList[i].TotalCarFuelCost;
                    worksheet.Cells[i + 20, 2].Value = objectList[i].InstallationTotalCost;
                    worksheet.Cells[i + 20, 3].Value = objectList[i].InstallationTotalCostCurrency;


                    worksheet.Cells[i + 22, 1].Value = objectList[i].NumberTrucksUsed;
                    worksheet.Cells[i + 22, 2].Value = objectList[i].TruckUnitPrice;
                    worksheet.Cells[i + 22, 3].Value = objectList[i].ShippingTotalCost;
                    worksheet.Cells[i + 22, 4].Value = objectList[i].ShippingTotalCostCurrency;




                    // Diğer özellikleri ekleyin







                    for (int a = 0; a < 22; a++)
                    {
                        //// Hücre içindeki metni ortala
                        worksheet.Cells[a + 1, 1, a + 1, worksheet.Dimension.Columns].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[a + 1, 1, a + 1, worksheet.Dimension.Columns].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        // Hücrelere kenarlık ekle
                        int currentRow = a + 1;
                        using (var range = worksheet.Cells[currentRow, 1, currentRow, worksheet.Dimension.Columns])
                        {
                            range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                            range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                            range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        }
                        for (int b = 0; b < 5; b++)
                        {
                            worksheet.Cells[a + 1, b + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[a + 1, b + 1].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                        }

                    }


                }

                // Hücrelere sığdırma
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                // MemoryStream'e yazın
                var memoryStream = new MemoryStream();
                package.SaveAs(memoryStream);

                return memoryStream;
            }
        }




    }
}

