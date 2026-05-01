using DataStructures.Mastery.Lab.SortedList;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // إعداد الترميز ليدعم الرموز إذا احتجت
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("--- Smart Dental Lab Management System --- \n");

        /*المهمة الأولى: فلترة المواعيد (Range Query)
المدير يريد تقريراً بالحالات التي تقع أرقامها بين 100 و 110 فقط.

المطلوب: اكتب كود LINQ يستخرج هذه الحالات من CaseSchedule ويعرضها مرتبة (هي مرتبة بالفعل، لكن استخرجها فقط).*/


        var CaseBetween100To110 = SortedListLesson.CaseSchedule.Where(CS =>
                                                                CS.Key > 100);

        foreach (var item in CaseBetween100To110)
        {
            Console.WriteLine($"- Key = {item.Key}   Value = {item.Value}");
        }



        /*المهمة الثانية: تحليل الأسعار (Value Filtering)
المحاسب يريد معرفة الخامات "الغالية" التي يتخطى سعرها 50 دولار.

المطلوب: اكتب كود LINQ يبحث في MaterialPrices ويجلب فقط الخامات التي قيمتها (Value) أكبر من 50.

المهمة الثالثة: قائمة النخبة (Projection)*/

        var MaterialPricesUp50 = SortedListLesson.MaterialPrices.Where(mp =>
                                                                    mp.Value > 50);

        Console.WriteLine("MaterialPrices Up TO 50 SD");
        foreach (var item in MaterialPricesUp50)
        {
            Console.WriteLine($"- Key = {item.Key}   Value = {item.Value}");
        }

        /*المهمة الثالثة: قائمة النخبة (Projection)
نريد تكريم الأطباء الذين لديهم أكثر من 600 نقطة ولاء.

المطلوب: اكتب كود LINQ يفلتر DoctorPoints ثم "يستخرج الأسماء فقط" (Names Only) ويحولها إلى List<string>.*/

        List<string> DoctorList = SortedListLesson.DoctorPoints.Where(dp => dp.Value > 600).Select
                                                                     (dp => dp.Key).ToList();

        foreach (var item in DoctorList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();

    }
}