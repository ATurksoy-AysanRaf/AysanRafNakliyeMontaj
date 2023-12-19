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

                // Sayfa düzeni ve baskı seçeneklerini ayarlayın
                worksheet.PrinterSettings.Orientation = eOrientation.Landscape;
                worksheet.PrinterSettings.FitToPage = true;
                worksheet.PrinterSettings.FitToWidth = 1;
                worksheet.PrinterSettings.FitToHeight = 1;


                int startRow1 =1;
                int endRow1 = 1;
                int startColumn1 = 1;
                int endColumn1 = 5;

                // Belirtilen hücre aralığını birleştir
                worksheet.Cells[startRow1, startColumn1, endRow1, endColumn1].Merge = true;

                // Başlık metni
                worksheet.Cells[startRow1, startColumn1].Value = " PLANLANAN TEKLİF FORMU " ;

                // Başlık hücrenin stilini düzenleme
                worksheet.Cells[startRow1, startColumn1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow1, startColumn1].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                worksheet.Cells[startRow1, startColumn1].Style.Font.Bold = true;
                // Yazı boyutunu büyütme
                var titleCell2 = worksheet.Cells[startRow1, startColumn1];
                titleCell2.Style.Font.Size = 16; // İstediğiniz boyutu ayarlayabilirsiniz
                int startRow2 = 1;
                int endRow2 = 1;
                int startColumn2 = 7;
                int endColumn2 = 11;

                // Belirtilen hücre aralığını birleştir
                worksheet.Cells[startRow2, startColumn2, endRow2, endColumn2].Merge = true;

                // Başlık metni
                worksheet.Cells[startRow2, startColumn2].Value = "GERÇEKLEŞEN TEKLİF FORMU";

                // Başlık hücresinin stilini düzenleme
                var titleCell = worksheet.Cells[startRow2, startColumn2];
                titleCell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                titleCell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                titleCell.Style.Font.Bold = true;

                // Yazı boyutunu büyütme
                titleCell.Style.Font.Size = 16; // İstediğiniz boyutu ayarlayabilirsiniz

                // Yazı rengini mavi yapma
                titleCell.Style.Font.Color.SetColor(Color.Blue);


                int startRow3 = 1;
                int endRow3 = 21;
                int startColumn3 = 6;
                int endColumn3 = 6;

                // Belirtilen hücre aralığını birleştir
                worksheet.Cells[startRow3, startColumn3, endRow3, endColumn3].Merge = true;

              



                // Başlık ekleyin
                //Planlanan
                worksheet.Cells[3, 1].Value = "Sipariş Numarası";
                worksheet.Cells[3, 2].Value = "Tarih";
                worksheet.Cells[3, 3].Value = "Kur";
               
                worksheet.Cells[3, 4].Value = "Şehir";

                worksheet.Cells[5, 1].Value = "Teklif Tonaj";
                worksheet.Cells[5, 2].Value = "Gerçek Tonaj";
                worksheet.Cells[5, 3].Value = "Günlük Tonaj";
                worksheet.Cells[5, 4].Value = "Gün Sayısı";
                worksheet.Cells[5, 5].Value = "Çalışan Sayısı";

                worksheet.Cells[7, 1].Value = "Günlük Yevmiye";
                worksheet.Cells[7, 2].Value = "Toplam Yevmiye";
                worksheet.Cells[7, 3].Value = "ISG Uzmanı";
                worksheet.Cells[7, 4].Value = "Saha Mühendisi";
                worksheet.Cells[7, 5].Value = "(1) Toplam Yevmiye Tutarı";

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
                worksheet.Cells[17, 3].Value = "Yemek Birim Maliyeti";
                worksheet.Cells[17, 5].Value = "(2) Araba-Yakıt Maliyeti";

                worksheet.Cells[19, 1].Value = "(3) Ekipman Toplam Maliyeti";
                worksheet.Cells[19, 2].Value = "(4) Konaklama Toplam Maliyeti";
                worksheet.Cells[19, 3].Value = "(5) Yemek Toplam Maliyeti";
                worksheet.Cells[19, 4].Value = "(1+2+3+4+5)    Toplam Montaj Maliyeti(TL)";
                worksheet.Cells[19, 5].Value = "Toplam Montaj Maliyeti(USD)";

                worksheet.Cells[21, 1].Value = "Tır Sayısı";
                worksheet.Cells[21, 2].Value = "Tır Birim Maliyeti";
                worksheet.Cells[21, 4].Value = "Toplam Nakliye Maliyeti(TL)";
                worksheet.Cells[21, 5].Value = "Toplam Nakliye Maliyeti(USD)";


                //gerçekleşen

                worksheet.Cells[3, 7].Value = "Sipariş Numarası";
                worksheet.Cells[3, 8].Value = "Tarih";
                worksheet.Cells[3, 9].Value = "Kur";
                
                worksheet.Cells[3, 10].Value = "Şehir";

                worksheet.Cells[5, 7].Value = "Teklif Tonaj";
                worksheet.Cells[5, 8].Value = "Gerçek Tonaj";
                worksheet.Cells[5, 9].Value = "Günlük Tonaj";
                worksheet.Cells[5, 10].Value = "Gün Sayısı";
                worksheet.Cells[5, 11].Value = "Çalışan Sayısı";

                worksheet.Cells[7, 7].Value = "Günlük Yevmiye";
                worksheet.Cells[7, 8].Value = "Toplam Yevmiye";
                worksheet.Cells[7, 9].Value = "ISG Uzmanı";
                worksheet.Cells[7, 10].Value = "Saha Mühendisi";
                worksheet.Cells[7, 11].Value = "(1) Toplam Yevmiye Tutarı";

                worksheet.Cells[9, 7].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[9, 8].Value = "Günlük Maliyeti";
                worksheet.Cells[9, 9].Value = "Aylık Maliyeti";
                worksheet.Cells[9, 10].Value = "Adeti";
                worksheet.Cells[9, 11].Value = "Toplam Maliyeti";

                worksheet.Cells[11, 7].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[11, 8].Value = "Günlük Maliyeti";
                worksheet.Cells[11, 9].Value = "Aylık Maliyeti";
                worksheet.Cells[11, 10].Value = "Adeti";
                worksheet.Cells[11, 11].Value = "Toplam Maliyeti";

                worksheet.Cells[13, 7].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[13, 8].Value = "Günlük Maliyeti";
                worksheet.Cells[13, 9].Value = "Aylık Maliyeti";
                worksheet.Cells[13, 10].Value = "Adeti";
                worksheet.Cells[13, 11].Value = "Toplam Maliyeti";

                worksheet.Cells[15, 7].Value = "Kiralanan Ekipman Adı";
                worksheet.Cells[15, 8].Value = "Günlük Maliyeti";
                worksheet.Cells[15, 9].Value = "Aylık Maliyeti";
                worksheet.Cells[15, 10].Value = "Adeti";
                worksheet.Cells[15, 11].Value = "Toplam Maliyeti";


                worksheet.Cells[17, 7].Value = "Ekipman Nakliye Maliyeti";
                worksheet.Cells[17, 8].Value = "Konaklama Birim Maliyeti";
                worksheet.Cells[17, 9].Value = "Yemek Birim Maliyeti";
                worksheet.Cells[17, 11].Value = "(2) Araba-Yakıt Maliyeti";

                worksheet.Cells[19, 7].Value = "(3) Ekipman Toplam Maliyeti";
                worksheet.Cells[19, 8].Value = "(4) Konaklama Toplam Maliyeti";
                worksheet.Cells[19, 9].Value = "(5) Yemek Toplam Maliyeti";
                worksheet.Cells[19, 10].Value = "(1+2+3+4+5)    Toplam Montaj Maliyeti(TL)";
                worksheet.Cells[19, 11].Value = "Toplam Montaj Maliyeti(USD)";

                worksheet.Cells[21, 7].Value = "Tır Sayısı";
                worksheet.Cells[21, 8].Value = "Tır Birim Maliyeti";
                worksheet.Cells[21, 10].Value = "Toplam Nakliye Maliyeti(TL)";
                worksheet.Cells[21, 11].Value = "Toplam Nakliye Maliyeti(USD)";
                // Verileri ekleyin
                for (int i = 0; i < objectList.Count; i++)
                {   //PLANLANAN

                    int startRow4 = 2;
                    int endRow4 = 2;
                    int startColumn4 = 1;
                    int endColumn4 = 5;

                    // Belirtilen hücre aralığını birleştir
                    worksheet.Cells[startRow4, startColumn4, endRow4, endColumn4].Merge = true;

                    // Başlık metni
                    worksheet.Cells[startRow4, startColumn4].Value = " Müşteri: "+ objectList[i].PlannedOfferForm.CustomerName.ToUpper(); ;

                    worksheet.Cells[startRow4, startColumn4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left; // Başa dayamak için Left kullanılır
                    worksheet.Cells[startRow4, startColumn4].Style.VerticalAlignment = ExcelVerticalAlignment.Center; // İster iseniz hücreyi dikeyde ortala

                    worksheet.Cells[startRow4, startColumn4].Style.Font.Bold = true;


                    worksheet.Cells[i + 4, 1].Value = objectList[i].PlannedOfferForm.SalesOfferNumber; // Property1 yerine gerçek özellik adını yazın
                    worksheet.Cells[i + 4, 2].Value = objectList[i].PlannedOfferForm.CreatedDate;
                    worksheet.Cells[i + 4, 2].Style.Numberformat.Format = "yyyy/mm/dd";
                    worksheet.Cells[i + 4, 3].Value = objectList[i].PlannedOfferForm.ExchangeRate;
                    worksheet.Cells[i + 4, 3].Style.Numberformat.Format = "#,##0.0000";
                   
                    worksheet.Cells[i + 4, 4].Value = objectList[i].PlannedOfferForm.CustomerCity.ToUpper();

                    worksheet.Cells[i + 6, 1].Value = objectList[i].PlannedOfferForm.OfferTonnage;
                    worksheet.Cells[i + 6, 1].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 6, 2].Value = objectList[i].PlannedOfferForm.ReallyTonnage;
                    worksheet.Cells[i + 6, 2].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 6, 3].Value = objectList[i].PlannedOfferForm.DailyTonnage;
                    worksheet.Cells[i + 6, 3].Style.Numberformat.Format = "#,##0.00";

                    worksheet.Cells[i + 6, 4].Value = Math.Ceiling(objectList[i].PlannedOfferForm.NumberDays);

                    worksheet.Cells[i + 6, 5].Value = objectList[i].PlannedOfferForm.NumberEmployees;


                    worksheet.Cells[i + 8, 1].Value = objectList[i].PlannedOfferForm.DailyWageCost;
                    worksheet.Cells[i + 8, 1].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 8, 2].Value = objectList[i].PlannedOfferForm.TotalWageAmount;
                    worksheet.Cells[i + 8, 3].Value = objectList[i].PlannedOfferForm.IsgexpertCost;
                    worksheet.Cells[i + 8, 3].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 8, 4].Value = objectList[i].PlannedOfferForm.FieldEngineerCost;
                    worksheet.Cells[i + 8, 4].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 8, 5].Value = objectList[i].PlannedOfferForm.WageTotalCost;
                    worksheet.Cells[i + 8, 5].Style.Font.Color.SetColor(Color.Blue);
                    worksheet.Cells[i + 8, 5].Style.Numberformat.Format = "#,##0.00";


                    worksheet.Cells[i + 10, 1].Value = objectList[i].PlannedOfferForm.RentedEquipmentName1.ToUpper();
                    worksheet.Cells[i + 10, 2].Value = objectList[i].PlannedOfferForm.RentedEquipmentDailyCost1;
                    worksheet.Cells[i + 10, 2].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 10, 3].Value = objectList[i].PlannedOfferForm.RentedEquipmentMonthlyCost1;
                    worksheet.Cells[i + 10, 3].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 10, 4].Value = objectList[i].PlannedOfferForm.RentedEquipmentAmount1;
                    worksheet.Cells[i + 10, 4].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 10, 5].Value = objectList[i].PlannedOfferForm.RentedEquipmentTotalCost1;
                    worksheet.Cells[i + 10, 5].Style.Numberformat.Format = "#,##0.00";


                    worksheet.Cells[i + 12, 1].Value = objectList[i].PlannedOfferForm.RentedEquipmentName2.ToUpper();
                    worksheet.Cells[i + 12, 2].Value = objectList[i].PlannedOfferForm.RentedEquipmentDailyCost2;
                    worksheet.Cells[i + 12, 2].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 12, 3].Value = objectList[i].PlannedOfferForm.RentedEquipmentMonthlyCost2;
                    worksheet.Cells[i + 12, 3].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 12, 4].Value = objectList[i].PlannedOfferForm.RentedEquipmentAmount2;
                    worksheet.Cells[i + 12, 4].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 12, 5].Value = objectList[i].PlannedOfferForm.RentedEquipmentTotalCost2;
                    worksheet.Cells[i + 12, 5].Style.Numberformat.Format = "#,##0.00";


                    worksheet.Cells[i + 14, 1].Value = objectList[i].PlannedOfferForm.RentedEquipmentName3.ToUpper();
                    worksheet.Cells[i + 14, 2].Value = objectList[i].PlannedOfferForm.RentedEquipmentDailyCost3;
                    worksheet.Cells[i + 14, 2].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 14, 3].Value = objectList[i].PlannedOfferForm.RentedEquipmentMonthlyCost3;
                    worksheet.Cells[i + 14, 3].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 14, 4].Value = objectList[i].PlannedOfferForm.RentedEquipmentAmount3;
                    worksheet.Cells[i + 14, 4].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 14, 5].Value = objectList[i].PlannedOfferForm.RentedEquipmentTotalCost3;
                    worksheet.Cells[i + 14, 5].Style.Numberformat.Format = "#,##0.00";


                    worksheet.Cells[i + 16, 1].Value = objectList[i].PlannedOfferForm.RentedEquipmentName4.ToUpper();
                    worksheet.Cells[i + 16, 2].Value = objectList[i].PlannedOfferForm.RentedEquipmentDailyCost4;
                    worksheet.Cells[i + 16, 2].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 16, 3].Value = objectList[i].PlannedOfferForm.RentedEquipmentMonthlyCost4;
                    worksheet.Cells[i + 16, 3].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 16, 4].Value = objectList[i].PlannedOfferForm.RentedEquipmentAmount4;
                    worksheet.Cells[i + 16, 4].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 16, 5].Value = objectList[i].PlannedOfferForm.RentedEquipmentTotalCost4;
                    worksheet.Cells[i + 16, 5].Style.Numberformat.Format = "#,##0.00";



                    worksheet.Cells[i + 18, 1].Value = objectList[i].PlannedOfferForm.EquipmentShipmentCost;
                    worksheet.Cells[i + 18, 1].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 18, 2].Value = objectList[i].PlannedOfferForm.AccommodationUnitPrice;
                    worksheet.Cells[i + 18, 2].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 18, 3].Value = objectList[i].PlannedOfferForm.StaffMealUnitPrice;
                    worksheet.Cells[i + 18, 3].Style.Numberformat.Format = "#,##0.00";

                    worksheet.Cells[i + 18, 5].Value = objectList[i].PlannedOfferForm.TotalCarFuelCost;
                    worksheet.Cells[i + 18, 5].Style.Font.Color.SetColor(Color.Blue);
                    worksheet.Cells[i + 18, 5].Style.Numberformat.Format = "#,##0.00";

                    worksheet.Cells[i + 20, 1].Value = objectList[i].PlannedOfferForm.EquipmentSumCost;
                    worksheet.Cells[i + 20, 1].Style.Font.Color.SetColor(Color.Blue);
                    worksheet.Cells[i + 20, 1].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 20, 2].Value = objectList[i].PlannedOfferForm.AccommodationTotalPrice;
                    worksheet.Cells[i + 20, 2].Style.Font.Color.SetColor(Color.Blue);
                    worksheet.Cells[i + 20, 2].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 20, 3].Value = objectList[i].PlannedOfferForm.StaffMealTotalPrice;
                    worksheet.Cells[i + 20, 3].Style.Font.Color.SetColor(Color.Blue);
                    worksheet.Cells[i + 20, 3].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 20, 4].Value = objectList[i].PlannedOfferForm.InstallationTotalCost;
                    worksheet.Cells[i + 20, 4].Style.Font.Color.SetColor(Color.Red);
                    worksheet.Cells[i + 20, 4].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 20, 5].Value = objectList[i].PlannedOfferForm.InstallationTotalCostCurrency;
                    worksheet.Cells[i + 20, 5].Style.Font.Color.SetColor(Color.Red);
                    worksheet.Cells[i + 20, 5].Style.Numberformat.Format = "#,##0.00";




                    worksheet.Cells[i + 22, 1].Value = objectList[i].PlannedOfferForm.NumberTrucksUsed;
                    worksheet.Cells[i + 22, 2].Value = objectList[i].PlannedOfferForm.TruckUnitPrice;
                    worksheet.Cells[i + 22, 2].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 22, 4].Value = objectList[i].PlannedOfferForm.ShippingTotalCost;
                    worksheet.Cells[i + 22, 4].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 22, 4].Style.Font.Color.SetColor(Color.Red);
                    worksheet.Cells[i + 22, 5].Value = objectList[i].PlannedOfferForm.ShippingTotalCostCurrency;
                    worksheet.Cells[i + 22, 5].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 22, 5].Style.Font.Color.SetColor(Color.Red);


                    //GERÇEKLEŞEN


                    int startRow5 = 2;
                    int endRow5 = 2;
                    int startColumn5 = 7;
                    int endColumn5 = 11;

                    // Belirtilen hücre aralığını birleştir
                    worksheet.Cells[startRow5, startColumn5, endRow5, endColumn5].Merge = true;

                    // Başlık metni
                    worksheet.Cells[startRow5, startColumn5].Value = " Müşteri: " + objectList[i].RealizedOfferForm.CustomerName.ToUpper(); ;

                    worksheet.Cells[startRow5, startColumn5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left; // Başa dayamak için Left kullanılır
                    worksheet.Cells[startRow5, startColumn5].Style.VerticalAlignment = ExcelVerticalAlignment.Center; // İster iseniz hücreyi dikeyde ortala

                    worksheet.Cells[startRow1, startColumn1].Style.Font.Bold = true;



                    worksheet.Cells[i + 4, 7].Value = objectList[i].RealizedOfferForm.SalesOfferNumber; // Property1 yerine gerçek özellik adını yazın
                    worksheet.Cells[i + 4, 8].Value = objectList[i].RealizedOfferForm.CreatedDate;
                    worksheet.Cells[i + 4, 8].Style.Numberformat.Format = "yyyy/mm/dd";
                    worksheet.Cells[i + 4, 9].Value = objectList[i].RealizedOfferForm.ExchangeRate;
                    worksheet.Cells[i + 4, 9].Style.Numberformat.Format = "#,##0.0000";
                   
                    worksheet.Cells[i + 4, 10].Value = objectList[i].RealizedOfferForm.CustomerCity.ToUpper();

                    worksheet.Cells[i + 6, 7].Value = objectList[i].RealizedOfferForm.OfferTonnage;
                    worksheet.Cells[i + 6, 7].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 6, 8].Value = objectList[i].RealizedOfferForm.ReallyTonnage;
                    worksheet.Cells[i + 6, 8].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 6, 9].Value = objectList[i].RealizedOfferForm.DailyTonnage;
                    worksheet.Cells[i + 6, 9].Style.Numberformat.Format = "#,##0.00";

                    worksheet.Cells[i + 6, 10].Value = Math.Ceiling(objectList[i].RealizedOfferForm.NumberDays);

                    worksheet.Cells[i + 6, 11].Value = objectList[i].RealizedOfferForm.NumberEmployees;


                    worksheet.Cells[i + 8, 7].Value = objectList[i].RealizedOfferForm.DailyWageCost;
                    worksheet.Cells[i + 8, 7].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 8, 8].Value = objectList[i].RealizedOfferForm.TotalWageAmount;
                    worksheet.Cells[i + 8, 8].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 8, 9].Value = objectList[i].RealizedOfferForm.IsgexpertCost;
                    worksheet.Cells[i + 8, 9].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 8, 10].Value = objectList[i].RealizedOfferForm.FieldEngineerCost;
                    worksheet.Cells[i + 8, 10].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 8, 11].Value = objectList[i].RealizedOfferForm.WageTotalCost;
                    worksheet.Cells[i + 8, 11].Style.Font.Color.SetColor(Color.Blue);
                    worksheet.Cells[i + 8, 11].Style.Numberformat.Format = "#,##0.00";


                    worksheet.Cells[i + 10, 7].Value = objectList[i].RealizedOfferForm.RentedEquipmentName1.ToUpper();
                    worksheet.Cells[i + 10, 8].Value = objectList[i].RealizedOfferForm.RentedEquipmentDailyCost1;
                    worksheet.Cells[i + 10, 8].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 10, 9].Value = objectList[i].RealizedOfferForm.RentedEquipmentMonthlyCost1;
                    worksheet.Cells[i + 10, 9].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 10, 10].Value = objectList[i].RealizedOfferForm.RentedEquipmentAmount1;
                    worksheet.Cells[i + 10, 10].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 10, 11].Value = objectList[i].RealizedOfferForm.RentedEquipmentTotalCost1;
                    worksheet.Cells[i + 10, 11].Style.Numberformat.Format = "#,##0.00";


                    worksheet.Cells[i + 12, 7].Value = objectList[i].RealizedOfferForm.RentedEquipmentName2.ToUpper();
                    worksheet.Cells[i + 12, 8].Value = objectList[i].RealizedOfferForm.RentedEquipmentDailyCost2;
                    worksheet.Cells[i + 12, 8].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 12, 9].Value = objectList[i].RealizedOfferForm.RentedEquipmentMonthlyCost2;
                    worksheet.Cells[i + 12, 9].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 12, 10].Value = objectList[i].RealizedOfferForm.RentedEquipmentAmount2;
                    worksheet.Cells[i + 12, 10].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 12, 11].Value = objectList[i].RealizedOfferForm.RentedEquipmentTotalCost2;
                    worksheet.Cells[i + 12, 11].Style.Numberformat.Format = "#,##0.00";


                    worksheet.Cells[i + 14, 7].Value = objectList[i].RealizedOfferForm.RentedEquipmentName3.ToUpper();
                    worksheet.Cells[i + 14, 8].Value = objectList[i].RealizedOfferForm.RentedEquipmentDailyCost3;
                    worksheet.Cells[i + 14, 8].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 14, 9].Value = objectList[i].RealizedOfferForm.RentedEquipmentMonthlyCost3;
                    worksheet.Cells[i + 14, 9].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 14, 10].Value = objectList[i].RealizedOfferForm.RentedEquipmentAmount3;
                    worksheet.Cells[i + 14, 10].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 14, 11].Value = objectList[i].RealizedOfferForm.RentedEquipmentTotalCost3;
                    worksheet.Cells[i + 14, 11].Style.Numberformat.Format = "#,##0.00";


                    worksheet.Cells[i + 16, 7].Value = objectList[i].RealizedOfferForm.RentedEquipmentName4.ToUpper();
                    worksheet.Cells[i + 16, 8].Value = objectList[i].RealizedOfferForm.RentedEquipmentDailyCost4;
                    worksheet.Cells[i + 16, 8].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 16, 9].Value = objectList[i].RealizedOfferForm.RentedEquipmentMonthlyCost4;
                    worksheet.Cells[i + 16, 9].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 16, 10].Value = objectList[i].RealizedOfferForm.RentedEquipmentAmount4;
                    worksheet.Cells[i + 16, 10].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 16, 11].Value = objectList[i].RealizedOfferForm.RentedEquipmentTotalCost4;
                    worksheet.Cells[i + 15, 11].Style.Numberformat.Format = "#,##0.00";



                    worksheet.Cells[i + 18, 7].Value = objectList[i].RealizedOfferForm.EquipmentShipmentCost;
                    worksheet.Cells[i + 18, 7].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 18, 8].Value = objectList[i].RealizedOfferForm.AccommodationUnitPrice;
                    worksheet.Cells[i + 18, 8].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 18, 9].Value = objectList[i].RealizedOfferForm.StaffMealUnitPrice;
                    worksheet.Cells[i + 18, 9].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 18, 11].Value = objectList[i].RealizedOfferForm.TotalCarFuelCost;
                    worksheet.Cells[i + 18, 11].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 18, 11].Style.Font.Color.SetColor(Color.Blue);

                    worksheet.Cells[i + 20, 7].Value = objectList[i].RealizedOfferForm.EquipmentSumCost;
                    worksheet.Cells[i + 20, 7].Style.Font.Color.SetColor(Color.Blue);
                    worksheet.Cells[i + 20, 7].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 20, 8].Value = objectList[i].RealizedOfferForm.AccommodationTotalPrice;
                    worksheet.Cells[i + 20, 8].Style.Font.Color.SetColor(Color.Blue);
                    worksheet.Cells[i + 20, 8].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 20, 9].Value = objectList[i].RealizedOfferForm.StaffMealTotalPrice;
                    worksheet.Cells[i + 20, 9].Style.Font.Color.SetColor(Color.Blue);
                    worksheet.Cells[i + 20, 9].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 20, 10].Value = objectList[i].RealizedOfferForm.InstallationTotalCost;
                    worksheet.Cells[i + 20, 10].Style.Font.Color.SetColor(Color.Red);
                    worksheet.Cells[i + 20, 10].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 20, 11].Value = objectList[i].RealizedOfferForm.InstallationTotalCostCurrency;
                    worksheet.Cells[i + 20, 11].Style.Font.Color.SetColor(Color.Red);
                    worksheet.Cells[i + 20, 11].Style.Numberformat.Format = "#,##0.00";

                    worksheet.Cells[i + 22, 7].Value = objectList[i].RealizedOfferForm.NumberTrucksUsed;
                    worksheet.Cells[i + 22, 8].Value = objectList[i].RealizedOfferForm.TruckUnitPrice;
                    worksheet.Cells[i + 22, 8].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 22, 10].Value = objectList[i].RealizedOfferForm.ShippingTotalCost;
                    worksheet.Cells[i + 22, 10].Style.Font.Color.SetColor(Color.Red);
                    worksheet.Cells[i + 22, 10].Style.Numberformat.Format = "#,##0.00";
                    worksheet.Cells[i + 22, 11].Value = objectList[i].RealizedOfferForm.ShippingTotalCostCurrency;
                    worksheet.Cells[i + 22, 11].Style.Font.Color.SetColor(Color.Red);
                    worksheet.Cells[i + 22, 11].Style.Numberformat.Format = "#,##0.00";

                    // Diğer özellikleri ekleyin







                    for (int a = 0; a < 22; a++)
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
                            if (a % 2 == 1)
                            {
                               
                                worksheet.Cells[a + 1, b + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                worksheet.Cells[a + 1, b + 1].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                            }
                        }
                        for (int b = 0; b < 5; b++)

                        {
                            worksheet.Column(a + 1).Width = 20;
                            if (a%2 == 1) { 
                           
                            worksheet.Cells[a + 1, b + 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[a + 1, b + 7].Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                        }
                        }
                        // Tüm hücre boyutlarını eşitle

                        worksheet.Row(currentRow).Height = 38;
                    }

                    worksheet.Column(2).Width = 20;
                    worksheet.Column(4).Width = 15;
                    worksheet.Column(6).Width = 5;
                    worksheet.Column(8).Width = 20;
                    worksheet.Column(10).Width = 15;
                    worksheet.Row(19).Height = 40;
                   

                }


                // MemoryStream'e yazın
                var memoryStream = new MemoryStream();
                package.SaveAs(memoryStream);

                return memoryStream;
            }
        }
    }
}