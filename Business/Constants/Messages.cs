using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ürünEklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime = "Sisten Bakımda";
        internal static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir ";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldığı için yeni ürün eklenemiyor";
    }
}
