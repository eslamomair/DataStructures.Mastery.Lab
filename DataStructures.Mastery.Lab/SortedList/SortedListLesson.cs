namespace DataStructures.Mastery.Lab.SortedList
{
    public static class SortedListLesson
    {
        // 1. جدول مواعيد تسليم الحالات (رقم الحالة، اسم المريض/الطبيب)
        // لاحظ أن العناصر ستترتب تلقائياً حسب رقم الحالة (Key)
        public static SortedList<int, string> CaseSchedule = new SortedList<int, string>
        {
            { 105, "حالة د. سارة - طقم أكريليك" },
            { 101, "حالة د. أحمد - زيركون" },
            { 110, "حالة د. هاني - فينير" },
            { 103, "حالة د. علي - إصلاح كسر" },
            { 120, "حالة د. مريم - طقم كامل" }
        };

        // 2. قائمة أسعار الخامات (اسم الخامة، السعر بالدولار)
        // ستترتب أبجدياً حسب اسم الخامة (Key)
        public static SortedList<string, decimal> MaterialPrices = new SortedList<string, decimal>
        {
            { "Zirconia", 150.5m },
            { "Acrylic", 45.0m },
            { "Porcelain", 85.0m },
            { "Wax", 12.0m },
            { "Plaster", 25.5m }
        };

        // 3. نقاط ولاء الأطباء (اسم الطبيب، عدد النقاط)
        public static SortedList<string, int> DoctorPoints = new SortedList<string, int>
        {
            { "Dr. Ahmed", 500 },
            { "Dr. Sara", 850 },
            { "Dr. Hani", 300 },
            { "Dr. Ali", 1200 }
        };
    }
}
