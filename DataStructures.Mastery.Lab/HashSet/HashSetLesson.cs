namespace DataStructures.Mastery.Lab.HashSet
{
    public static class HashSetLesson
    {

        // --- بيانات معمل الأسنان الأساسية ---

        // المخزن الرئيسي (A)
        public static HashSet<string> StoreA = new HashSet<string> { "D101", "D102", "S201", "M301", "D999" };

        // فرع المعمل الجديد (B)
        public static HashSet<string> BranchB = new HashSet<string> { "D102", "D103", "S201", "X401" };

        // قائمة الخامات منتهية الصلاحية (C)
        public static HashSet<string> ExpiredC = new HashSet<string> { "D101", "X401", "D999" };

        // خامات وصلت المعمل حديثاً (للمهمة الأولى)
        public static string[] RawArrivals = { "D101", "D101", "D1001", "S201", "D505", "D505", "D1", "D2002" };

        // شحنة جديدة وأمر توريد (للمهمة السادسة)
        public static HashSet<string> NewShipment = new HashSet<string> { "Acrylic", "Wax", "Porcelain" };
        public static HashSet<string> OrderRequest = new HashSet<string> { "Wax", "Porcelain", "Acrylic" };

        // 1. قائمة وزارة الصحة (المواد الإلزامية)
        public static HashSet<string> MandatoryMaterials = new HashSet<string> { "D101", "S201" };

        // 2. طلبيات الأطباء المتعارضة
        public static HashSet<string> DrAliOrder = new HashSet<string> { "D102", "M301" };
        public static HashSet<string> DrZainOrder = new HashSet<string> { "M301", "D999" };

        // 3. طلبية الـ VIP الضخمة
        public static HashSet<string> VipOrder = new HashSet<string> { "D101", "D103", "D505" };
    }
}
