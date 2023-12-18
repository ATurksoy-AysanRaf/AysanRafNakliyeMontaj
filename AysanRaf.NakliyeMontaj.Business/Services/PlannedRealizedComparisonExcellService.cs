using Microsoft.EntityFrameworkCore;
using Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.Business.Services
{

    public class PlannedRealizedComparisonExcellService
    {
        private readonly aysanrafpopsepdevelopment_2023_09_10_05_45Context _context;

        public PlannedRealizedComparisonExcellService(aysanrafpopsepdevelopment_2023_09_10_05_45Context dbContext)
        {
            _context = dbContext;
        }
        public MemoryStream ExportToExcel(string salesOfferNumber)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // veya LicenseContext.Commercial

            var joinedData = from plannedOffer in _context.PlannedOfferForms
                             join otherData in _context.RealizedOfferForms on plannedOffer.SalesOfferNumber equals otherData.SalesOfferNumber
                             where plannedOffer.SalesOfferNumber == salesOfferNumber
                             select new
                             {
                                 PlannedOfferForm = plannedOffer,
                                 RealizedOfferForm = otherData
                             };

            var objectList = joinedData.ToList();
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");



                int startRow1 =1;
                int endRow1 = 1;
                int startColumn1 = 1;
                int endColumn1 = 5;

                // Belirtilen hücre aralığını birleştir
                worksheet.Cells[startRow1, startColumn1, endRow1, endColumn1].Merge = true;

                // Başlık metni
                worksheet.Cells[startRow1, startColumn1].Value = " PLANLANAN TEKLİF FORMU ";

                // Başlık hücrenin stilini düzenleme
                worksheet.Cells[startRow1, startColumn1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow1, startColumn1].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                worksheet.Cells[startRow1, startColumn1].Style.Font.Bold = true;

                int startRow2 = 1;
                int endRow2 = 1;
                int startColumn2 = 6;
                int endColumn2 = 10;

                // Belirtilen hücre aralığını birleştir
                worksheet.Cells[startRow2, startColumn2, endRow2, endColumn2].Merge = true;

                // Başlık metni
                worksheet.Cells[startRow2, startColumn2].Value = " GERÇEKLEŞEN TEKLİF FORMU ";

                // Başlık hücrenin stilini düzenleme
                worksheet.Cells[startRow2, startColumn2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow2, startColumn2].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                worksheet.Cells[startRow2, startColumn2].Style.Font.Bold = true;







                // Başlık ekleyin
                //Planlanan
                worksheet.Cells[2, 1].Value = "Sipariş Numarası";
                worksheet.Cells[2, 2].Value = "Tarih";
                worksheet.Cells[2, 3].Value = "Kur";
                worksheet.Cells[2, 4].Value = "Müşteri";
                worksheet.Cells[2, 5].Value = "Şehir";

                worksheet.Cells[4, 1].Value = "Teklif Tonaj";
                worksheet.Cells[4, 2].Value = "Gerçek Tonaj";
                worksheet.Cells[4, 3].Value = "Günlük Tonaj";
                worksheet.Cells[4, 4].Value = "Gün Sayısı";
                worksheet.Cells[4, 5].Value = "Çalışan Sayısı";

                worksheet.Cells[6, 1].Value = "Günlük Yevmiye";
                worksheet.Cells[6, 2].Value = "Toplam Yevmiye";
                worksheet.Cells[6, 3].Value = "ISG Uzmanı";
                worksheet.Cells[6, 4].Value = "Saha Mühendisi";
                worksheet.Cells[6, 5].Value = "Toplam Yevmiye Tutarı";

                worksheet.Cells[8, 1].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[8, 2].Value = "Günlük Maliyeti";
                worksheet.Cells[8, 3].Value = "Aylık Maliyeti";
                worksheet.Cells[8, 4].Value = "Adeti";
                worksheet.Cells[8, 5].Value = "Toplam Maliyeti";

                worksheet.Cells[10, 1].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[10, 2].Value = "Günlük Maliyeti";
                worksheet.Cells[10, 3].Value = "Aylık Maliyeti";
                worksheet.Cells[10, 4].Value = "Adeti";
                worksheet.Cells[10, 5].Value = "Toplam Maliyeti";

                worksheet.Cells[12, 1].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[12, 2].Value = "Günlük Maliyeti";
                worksheet.Cells[12, 3].Value = "Aylık Maliyeti";
                worksheet.Cells[12, 4].Value = "Adeti";
                worksheet.Cells[12, 5].Value = "Toplam Maliyeti";

                worksheet.Cells[14, 1].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[14, 2].Value = "Günlük Maliyeti";
                worksheet.Cells[14, 3].Value = "Aylık Maliyeti";
                worksheet.Cells[14, 4].Value = "Adeti";
                worksheet.Cells[14, 5].Value = "Toplam Maliyeti";


                worksheet.Cells[16, 1].Value = "Ekipman Nakliye Maliyeti";
                worksheet.Cells[16, 2].Value = "Konaklama Birim Maliyeti";
                worksheet.Cells[16, 3].Value = "Konaklama Toplam Maliyeti";
                worksheet.Cells[16, 4].Value = "Yemek Birim Maliyeti";
                worksheet.Cells[16, 5].Value = "Yemek Toplam Maliyeti";


                worksheet.Cells[18, 1].Value = "Araba-Yakıt Maliyeti";
                worksheet.Cells[18, 2].Value = "Toplam Montaj Maliyeti(TL)";
                worksheet.Cells[18, 3].Value = "Toplam Montaj Maliyeti(USD)";

                worksheet.Cells[20, 1].Value = "Tır Sayısı";
                worksheet.Cells[20, 2].Value = "Tır Birim Maliyeti";
                worksheet.Cells[20, 3].Value = "Toplam Nakliye Maliyeti(TL)";
                worksheet.Cells[20, 4].Value = "Toplam Nakliye Maliyeti(USD)";
                //gerçekleşen
               
                worksheet.Cells[2, 6].Value = "Sipariş Numarası";
                worksheet.Cells[2, 7].Value = "Tarih";
                worksheet.Cells[2, 8].Value = "Kur";
                worksheet.Cells[2, 9].Value = "Müşteri";
                worksheet.Cells[2, 10].Value = "Şehir";

                worksheet.Cells[4, 6].Value = "Teklif Tonaj";
                worksheet.Cells[4, 7].Value = "Gerçek Tonaj";
                worksheet.Cells[4, 8].Value = "Günlük Tonaj";
                worksheet.Cells[4, 9].Value = "Gün Sayısı";
                worksheet.Cells[4, 10].Value = "Çalışan Sayısı";

                worksheet.Cells[6, 6].Value = "Günlük Yevmiye";
                worksheet.Cells[6, 7].Value = "Toplam Yevmiye";
                worksheet.Cells[6, 8].Value = "ISG Uzmanı";
                worksheet.Cells[6, 9].Value = "Saha Mühendisi";
                worksheet.Cells[6, 10].Value = "Toplam Yevmiye Tutarı";

                worksheet.Cells[8, 6].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[8, 7].Value = "Günlük Maliyeti";
                worksheet.Cells[8, 8].Value = "Aylık Maliyeti";
                worksheet.Cells[8, 9].Value = "Adeti";
                worksheet.Cells[8, 10].Value = "Toplam Maliyeti";

                worksheet.Cells[10, 6].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[10, 7].Value = "Günlük Maliyeti";
                worksheet.Cells[10, 8].Value = "Aylık Maliyeti";
                worksheet.Cells[10, 9].Value = "Adeti";
                worksheet.Cells[10, 10].Value = "Toplam Maliyeti";

                worksheet.Cells[12, 6].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[12, 7].Value = "Günlük Maliyeti";
                worksheet.Cells[12, 8].Value = "Aylık Maliyeti";
                worksheet.Cells[12, 9].Value = "Adeti";
                worksheet.Cells[12, 10].Value = "Toplam Maliyeti";

                worksheet.Cells[14, 6].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[14, 7].Value = "Günlük Maliyeti";
                worksheet.Cells[14, 8].Value = "Aylık Maliyeti";
                worksheet.Cells[14, 9].Value = "Adeti";
                worksheet.Cells[14, 10].Value = "Toplam Maliyeti";


                worksheet.Cells[16, 6].Value = "Ekipman Nakliye Maliyeti";
                worksheet.Cells[16, 7].Value = "Konaklama Birim Maliyeti";
                worksheet.Cells[16, 8].Value = "Konaklama Toplam Maliyeti";
                worksheet.Cells[16, 9].Value = "Yemek Birim Maliyeti";
                worksheet.Cells[16, 10].Value = "Yemek Toplam Maliyeti";


                worksheet.Cells[18, 6].Value = "Araba-Yakıt Maliyeti";
                worksheet.Cells[18, 7].Value = "Toplam Montaj Maliyeti(TL)";
                worksheet.Cells[18, 8].Value = "Toplam Montaj Maliyeti(USD)";

                worksheet.Cells[20, 6].Value = "Tır Sayısı";
                worksheet.Cells[20, 7].Value = "Tır Birim Maliyeti";
                worksheet.Cells[20, 8].Value = "Toplam Nakliye Maliyeti(TL)";
                worksheet.Cells[20, 9].Value = "Toplam Nakliye Maliyeti(USD)";
                // Verileri ekleyin
                for (int i = 0; i < objectList.Count; i++)
                {   //PLANLANAN
                    worksheet.Cells[i + 3, 1].Value = objectList[i].PlannedOfferForm.SalesOfferNumber; // Property1 yerine gerçek özellik adını yazın
                    worksheet.Cells[i + 3, 2].Value = objectList[i].PlannedOfferForm.CreatedDate;
                    worksheet.Cells[i + 3, 2].Style.Numberformat.Format = "yyyy/mm/dd";
                    worksheet.Cells[i + 3, 3].Value = objectList[i].PlannedOfferForm.ExchangeRate;
                    worksheet.Cells[i + 3, 4].Value = objectList[i].PlannedOfferForm.CustomerName.ToUpper();
                    worksheet.Cells[i + 3, 5].Value = objectList[i].PlannedOfferForm.CustomerCity.ToUpper();

                    worksheet.Cells[i + 5, 1].Value = objectList[i].PlannedOfferForm.OfferTonnage;
                    worksheet.Cells[i + 5, 2].Value = objectList[i].PlannedOfferForm.ReallyTonnage;
                    worksheet.Cells[i + 5, 3].Value = objectList[i].PlannedOfferForm.DailyTonnage;

                    worksheet.Cells[i + 5, 4].Value = Math.Ceiling(objectList[i].PlannedOfferForm.NumberDays);

                    worksheet.Cells[i + 5, 5].Value = objectList[i].PlannedOfferForm.NumberEmployees;


                    worksheet.Cells[i + 7, 1].Value = objectList[i].PlannedOfferForm.DailyWageCost;
                    worksheet.Cells[i + 7, 2].Value = objectList[i].PlannedOfferForm.TotalWageAmount;
                    worksheet.Cells[i + 7, 3].Value = objectList[i].PlannedOfferForm.IsgexpertCost;
                    worksheet.Cells[i + 7, 4].Value = objectList[i].PlannedOfferForm.FieldEngineerCost;
                    worksheet.Cells[i + 7, 5].Value = objectList[i].PlannedOfferForm.WageTotalCost;


                    worksheet.Cells[i + 9, 1].Value = objectList[i].PlannedOfferForm.RentedEquipmentName1.ToUpper();
                    worksheet.Cells[i + 9, 2].Value = objectList[i].PlannedOfferForm.RentedEquipmentDailyCost1;
                    worksheet.Cells[i + 9, 3].Value = objectList[i].PlannedOfferForm.RentedEquipmentMonthlyCost1;
                    worksheet.Cells[i + 9, 4].Value = objectList[i].PlannedOfferForm.RentedEquipmentAmount1;
                    worksheet.Cells[i + 9, 5].Value = objectList[i].PlannedOfferForm.RentedEquipmentTotalCost1;


                    worksheet.Cells[i + 11, 1].Value = objectList[i].PlannedOfferForm.RentedEquipmentName2.ToUpper();
                    worksheet.Cells[i + 11, 2].Value = objectList[i].PlannedOfferForm.RentedEquipmentDailyCost2;
                    worksheet.Cells[i + 11, 2].Value = objectList[i].PlannedOfferForm.RentedEquipmentDailyCost2;
                    worksheet.Cells[i + 11, 3].Value = objectList[i].PlannedOfferForm.RentedEquipmentMonthlyCost2;
                    worksheet.Cells[i + 11, 4].Value = objectList[i].PlannedOfferForm.RentedEquipmentAmount2;
                    worksheet.Cells[i + 11, 5].Value = objectList[i].PlannedOfferForm.RentedEquipmentTotalCost2;


                    worksheet.Cells[i + 13, 1].Value = objectList[i].PlannedOfferForm.RentedEquipmentName3.ToUpper();
                    worksheet.Cells[i + 13, 2].Value = objectList[i].PlannedOfferForm.RentedEquipmentDailyCost3;
                    worksheet.Cells[i + 13, 3].Value = objectList[i].PlannedOfferForm.RentedEquipmentMonthlyCost3;
                    worksheet.Cells[i + 13, 4].Value = objectList[i].PlannedOfferForm.RentedEquipmentAmount3;
                    worksheet.Cells[i + 13, 5].Value = objectList[i].PlannedOfferForm.RentedEquipmentTotalCost3;


                    worksheet.Cells[i + 15, 1].Value = objectList[i].PlannedOfferForm.RentedEquipmentName4.ToUpper();
                    worksheet.Cells[i + 15, 2].Value = objectList[i].PlannedOfferForm.RentedEquipmentDailyCost4;
                    worksheet.Cells[i + 15, 3].Value = objectList[i].PlannedOfferForm.RentedEquipmentMonthlyCost4;
                    worksheet.Cells[i + 15, 4].Value = objectList[i].PlannedOfferForm.RentedEquipmentAmount4;
                    worksheet.Cells[i + 15, 5].Value = objectList[i].PlannedOfferForm.RentedEquipmentTotalCost4;



                    worksheet.Cells[i + 17, 1].Value = objectList[i].PlannedOfferForm.EquipmentShipmentCost;
                    worksheet.Cells[i + 17, 2].Value = objectList[i].PlannedOfferForm.AccommodationUnitPrice;
                    worksheet.Cells[i + 17, 3].Value = objectList[i].PlannedOfferForm.AccommodationTotalPrice;
                    worksheet.Cells[i + 17, 4].Value = objectList[i].PlannedOfferForm.StaffMealUnitPrice;
                    worksheet.Cells[i + 17, 5].Value = objectList[i].PlannedOfferForm.StaffMealTotalPrice;

                    worksheet.Cells[i + 19, 1].Value = objectList[i].PlannedOfferForm.TotalCarFuelCost;
                    worksheet.Cells[i + 19, 2].Value = objectList[i].PlannedOfferForm.InstallationTotalCost;
                    worksheet.Cells[i + 19, 3].Value = objectList[i].PlannedOfferForm.InstallationTotalCostCurrency;


                    worksheet.Cells[i + 21, 1].Value = objectList[i].PlannedOfferForm.NumberTrucksUsed;
                    worksheet.Cells[i + 21, 2].Value = objectList[i].PlannedOfferForm.TruckUnitPrice;
                    worksheet.Cells[i + 21, 3].Value = objectList[i].PlannedOfferForm.ShippingTotalCost;
                    worksheet.Cells[i + 21, 4].Value = objectList[i].PlannedOfferForm.ShippingTotalCostCurrency;


                    //GERÇEKLEŞEN
                    worksheet.Cells[i + 3, 6].Value = objectList[i].RealizedOfferForm.SalesOfferNumber; // Property1 yerine gerçek özellik adını yazın
                    worksheet.Cells[i + 3, 7].Value = objectList[i].RealizedOfferForm.CreatedDate;
                    worksheet.Cells[i + 3, 7].Style.Numberformat.Format = "yyyy-mm-dd";
                    worksheet.Cells[i + 3, 8].Value = objectList[i].RealizedOfferForm.ExchangeRate;
                    worksheet.Cells[i + 3, 9].Value = objectList[i].RealizedOfferForm.CustomerName.ToUpper();
                    worksheet.Cells[i + 3, 10].Value = objectList[i].RealizedOfferForm.CustomerCity.ToUpper();

                    worksheet.Cells[i + 5, 6].Value = objectList[i].RealizedOfferForm.OfferTonnage;
                    worksheet.Cells[i + 5, 7].Value = objectList[i].RealizedOfferForm.ReallyTonnage;
                    worksheet.Cells[i + 5, 8].Value = objectList[i].RealizedOfferForm.DailyTonnage;

                    worksheet.Cells[i + 5, 9].Value = Math.Ceiling(objectList[i].RealizedOfferForm.NumberDays);

                    worksheet.Cells[i + 5, 10].Value = objectList[i].RealizedOfferForm.NumberEmployees;


                    worksheet.Cells[i + 7, 6].Value = objectList[i].RealizedOfferForm.DailyWageCost;
                    worksheet.Cells[i + 7, 7].Value = objectList[i].RealizedOfferForm.TotalWageAmount;
                    worksheet.Cells[i + 7, 8].Value = objectList[i].RealizedOfferForm.IsgexpertCost;
                    worksheet.Cells[i + 7, 9].Value = objectList[i].RealizedOfferForm.FieldEngineerCost;
                    worksheet.Cells[i + 7, 10].Value = objectList[i].RealizedOfferForm.WageTotalCost;


                    worksheet.Cells[i + 9, 6].Value = objectList[i].RealizedOfferForm.RentedEquipmentName1.ToUpper();
                    worksheet.Cells[i + 9, 7].Value = objectList[i].RealizedOfferForm.RentedEquipmentDailyCost1;
                    worksheet.Cells[i + 9, 8].Value = objectList[i].RealizedOfferForm.RentedEquipmentMonthlyCost1;
                    worksheet.Cells[i + 9, 9].Value = objectList[i].RealizedOfferForm.RentedEquipmentAmount1;
                    worksheet.Cells[i + 9, 10].Value = objectList[i].RealizedOfferForm.RentedEquipmentTotalCost1;


                    worksheet.Cells[i + 11, 6].Value = objectList[i].RealizedOfferForm.RentedEquipmentName2.ToUpper();
                    worksheet.Cells[i + 11, 7].Value = objectList[i].RealizedOfferForm.RentedEquipmentDailyCost2;
                    worksheet.Cells[i + 11, 7].Value = objectList[i].RealizedOfferForm.RentedEquipmentDailyCost2;
                    worksheet.Cells[i + 11, 8].Value = objectList[i].RealizedOfferForm.RentedEquipmentMonthlyCost2;
                    worksheet.Cells[i + 11, 9].Value = objectList[i].RealizedOfferForm.RentedEquipmentAmount2;
                    worksheet.Cells[i + 11, 10].Value = objectList[i].RealizedOfferForm.RentedEquipmentTotalCost2;


                    worksheet.Cells[i + 13, 6].Value = objectList[i].RealizedOfferForm.RentedEquipmentName3.ToUpper();
                    worksheet.Cells[i + 13, 7].Value = objectList[i].RealizedOfferForm.RentedEquipmentDailyCost3;
                    worksheet.Cells[i + 13, 8].Value = objectList[i].RealizedOfferForm.RentedEquipmentMonthlyCost3;
                    worksheet.Cells[i + 13, 9].Value = objectList[i].RealizedOfferForm.RentedEquipmentAmount3;
                    worksheet.Cells[i + 13, 10].Value = objectList[i].RealizedOfferForm.RentedEquipmentTotalCost3;


                    worksheet.Cells[i + 15, 6].Value = objectList[i].RealizedOfferForm.RentedEquipmentName4.ToUpper();
                    worksheet.Cells[i + 15, 7].Value = objectList[i].RealizedOfferForm.RentedEquipmentDailyCost4;
                    worksheet.Cells[i + 15, 8].Value = objectList[i].RealizedOfferForm.RentedEquipmentMonthlyCost4;
                    worksheet.Cells[i + 15, 9].Value = objectList[i].RealizedOfferForm.RentedEquipmentAmount4;
                    worksheet.Cells[i + 15, 10].Value = objectList[i].RealizedOfferForm.RentedEquipmentTotalCost4;



                    worksheet.Cells[i + 17, 6].Value = objectList[i].RealizedOfferForm.EquipmentShipmentCost;
                    worksheet.Cells[i + 17, 7].Value = objectList[i].RealizedOfferForm.AccommodationUnitPrice;
                    worksheet.Cells[i + 17, 8].Value = objectList[i].RealizedOfferForm.AccommodationTotalPrice;
                    worksheet.Cells[i + 17, 9].Value = objectList[i].RealizedOfferForm.StaffMealUnitPrice;
                    worksheet.Cells[i + 17, 10].Value = objectList[i].RealizedOfferForm.StaffMealTotalPrice;

                    worksheet.Cells[i + 19, 6].Value = objectList[i].RealizedOfferForm.TotalCarFuelCost;
                    worksheet.Cells[i + 19, 7].Value = objectList[i].RealizedOfferForm.InstallationTotalCost;
                    worksheet.Cells[i + 19, 8].Value = objectList[i].RealizedOfferForm.InstallationTotalCostCurrency;


                    worksheet.Cells[i + 21, 6].Value = objectList[i].RealizedOfferForm.NumberTrucksUsed;
                    worksheet.Cells[i + 21, 7].Value = objectList[i].RealizedOfferForm.TruckUnitPrice;
                    worksheet.Cells[i + 21, 8].Value = objectList[i].RealizedOfferForm.ShippingTotalCost;
                    worksheet.Cells[i + 21, 9].Value = objectList[i].RealizedOfferForm.ShippingTotalCostCurrency;


                    // Diğer özellikleri ekleyin




                    


                    for (int a = 0; a < 21; a++)
                    {


                        //// Hücre içindeki metni kaydırma
                        worksheet.Cells[a+1, 1, a+1, worksheet.Dimension.Columns].Style.WrapText = true;




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
                            worksheet.Column(a + 1).Width = 20;
                            worksheet.Cells[a + 1, b + 6].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[a + 1, b + 6].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                        }
                        // Tüm hücre boyutlarını eşitle
                        
                        
                        worksheet.Row(currentRow).Height = 35;
                    }


                }

              
                // MemoryStream'e yazın
                var memoryStream = new MemoryStream();
                package.SaveAs(memoryStream);

                return memoryStream;
            }
        }
    }
}