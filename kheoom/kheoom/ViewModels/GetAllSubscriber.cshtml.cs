using IronXL;
using Microsoft.AspNetCore.Mvc;

namespace kheoom.ViewModels
{
    public class GetAllSubscriber
    {
        //public FileResult OnPostExport()
        //{
        //    WorkBook workBook = new WorkBook(IronXL.ExcelFileFormat.XLSX);
        //    WorkSheet workSheet = workBook.CreateWorkSheet("data");
        //    //Add data and styles to the new worksheet
        //    workSheet["A1"].Value = "Name";
        //    workSheet["B1"].Value = "Email";
        //    workSheet["C1"].Value = "Marks";
        //    workSheet["D1"].Value = "Persent Age";
        //    workSheet["A1:D1"].Style.Font.Bold = true;
        //    workSheet["A2"].Value = "Nick";
        //    workSheet["A3"].Value = "Roy";
        //    workSheet["A4"].Value = "Chris";
        //    workSheet["B2"].Value = "Nick@gmail.com";
        //    workSheet["B3"].Value = "Roy123@gmail.com";
        //    workSheet["B4"].Value = "Chris1999@gmail.com";
        //    workSheet["C2"].Value = "850";
        //    workSheet["C3"].Value = "710";
        //    workSheet["C4"].Value = "990";
        //    workSheet["D2"].Value = "85%";
        //    workSheet["D3"].Value = "71%";
        //    workSheet["D4"].Value = "99%";
        //    return JsonContent(workBook.ToStream().ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Exported.xlsx");
        //}
    }
}
