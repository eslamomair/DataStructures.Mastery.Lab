using DataStructures.Mastery.Lab.HashSet;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // إعداد الترميز ليدعم الرموز إذا احتجت
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("--- Smart Dental Lab Management System --- \n");

        // 🛠️ المهمة الأولى: التصفية والاستعلام (استخدم LINQ و RawArrivals)

        Console.WriteLine("Task 1: Cleaning and filtering codes...");

        HashSet<string> set = new HashSet<string>(HashSetLesson.RawArrivals.Where(n => n.StartsWith("D") && n.Length > 3));

        foreach (var item in set)
        {
            Console.WriteLine($"- {item}");
        }





        // 🛠️ المهمة الثانية: الدمج الشامل (ادمج StoreA مع BranchB)
        Console.WriteLine("\nTask 2: Full merge of Main Store and Branch B...");
        // Your code for Task 2 here...

        // if we Don't want to modify the original StoreA, we can create a new HashSet and then merge
        HashSet<string> mergedSet = new HashSet<string>(HashSetLesson.StoreA);
        mergedSet.UnionWith(HashSetLesson.BranchB);


        foreach (var item in mergedSet)
        {
            Console.WriteLine($"- {item}");
        }

        // 🛠️ المهمة الثالثة: البحث عن التوافق (المواد المنتهية في StoreA)
        Console.WriteLine("\nTask 3: Detecting expired materials in Main Store...");
        // Your code for Task 3 here...

        HashSet<string> Expird = new HashSet<string>(HashSetLesson.StoreA);
        Expird.IntersectWith(HashSetLesson.ExpiredC);

        foreach (var item in Expird)
        {
            Console.WriteLine($"- {item}");
        }



        // 🛠️ المهمة الرابعة: التنظيف الفوري (احذف المنتهي من StoreA)
        Console.WriteLine("\nTask 4: Immediate disposal of damaged materials...");
        HashSetLesson.StoreA.ExceptWith(HashSetLesson.ExpiredC);
        foreach (var item in HashSetLesson.StoreA)
        {
            Console.WriteLine($"- {item}");
        }

        // 🛠️ المهمة الخامسة: كشف التميز (الموجود في A أو B وليس كليهما)
        Console.WriteLine("\nTask 5: Listing unique materials (Not shared between branches)...");
        HashSetLesson.BranchB.SymmetricExceptWith(HashSetLesson.StoreA);
        foreach (var item in HashSetLesson.BranchB)
        {
            Console.WriteLine($"- {item}");
        }


        // 🛠️ المهمة السادسة: فحص الشحنة (تطابق NewShipment مع OrderRequest)
        Console.WriteLine("\nTask 6: Checking shipment alignment with Order Request...");
        var isAligned = HashSetLesson.NewShipment.SetEquals(HashSetLesson.OrderRequest);
        Console.WriteLine(isAligned ? "Is Right" : "Not Right");

        //المطلوب: اطبع "المعمل مطابق للمواصفات" فقط إذا كان StoreA يحتوي على كل ما في MandatoryMaterials.
        // هذا المعادله يمكن ان يكون ناتجها خطا لعده اسباب
        /* 1. StoreA قد يحتوي على مواد اضافيه غير موجوده في MandatoryMaterials
             2. StoreA قد لا يحتوي على كل المواد الموجوده في MandatoryMaterials
             3. StoreA قد يحتوي على مواد منتهيه الصلاحيه او غير صالحة للاستخدام
        -- الناتج سيكون فولس لاننا طبقا شروط قبل هذه على الهاش سيت 
        */
        if (HashSetLesson.StoreA.SetEquals(HashSetLesson.MandatoryMaterials))
        {
            Console.WriteLine("The laboratory complies with the specifications");
        }
        else
        {
            Console.WriteLine("The laboratory does not comply with the specifications");
        }

        /* الحل الاكثر دقه هو استخدام IsSubsetOf للتحقق مما إذا كانت كل المواد الإلزامية موجودة في StoreA، بغض النظر عن وجود مواد إضافية أو منتهية الصلاحية.
         * */
        if (HashSetLesson.StoreA.IsSupersetOf(HashSetLesson.MandatoryMaterials))
        {
            Console.WriteLine("The laboratory complies with the specifications");
        }
        else
        {
            Console.WriteLine("The laboratory does not comply with the specifications");
        }



        if (HashSetLesson.DrAliOrder.Overlaps(HashSetLesson.DrZainOrder))
        {
            Console.WriteLine("Yes it Have");
        }
        else
            Console.WriteLine("No, its not Hvae");

        /*المهمة 3: جدوى الفرع (Branch Justification)

المعطيات: StoreA و BranchB.

المطلوب: هل كل العناصر الموجودة في BranchB موجودة بالفعل داخل StoreA؟ (لنعرف هل الفرع مكرر أم لا).
        */

        if (HashSetLesson.BranchB.IsSubsetOf(HashSetLesson.StoreA))
        {
            Console.WriteLine("Yes it Have");
        }
        else
            Console.WriteLine("No, its not Hvae");


        /*المهمة 4: فحص تغطية الطلبية الضخمة (VIP)

المعطيات: StoreA, BranchB, و VipOrder.

المطلوب: هل إجمالي المواد في (المخزن الرئيسي والفرع معاً) يغطي كافة احتياجات VipOrder؟
        */

        HashSet<string> ItCompleted = new HashSet<string>(HashSetLesson.StoreA);
        ItCompleted.UnionWith(HashSetLesson.BranchB);

        if (ItCompleted.IsSupersetOf(HashSetLesson.VipOrder))
        {
            Console.WriteLine("Yes , engho");
        }
        else
            Console.WriteLine("no , Not enghof");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();



    }
}