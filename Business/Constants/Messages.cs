using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategori de en fazla 10 ürün olabilir";
        public static string CheckIfProductNameExist="Bu isimde zaten başka ürün var";
        internal static string CategoryLimitExceded = "Kategori limit aşıldığı için yeni ürün ekelenemiyor";
        public static string AuthorizationDenied = "Yetkiniz Yok.";
    }
}
