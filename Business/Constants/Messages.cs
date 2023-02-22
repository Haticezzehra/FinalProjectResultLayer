using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
   public static class Messages
    {
        internal static string  MaintenanceTime="Sistem bakımda";
        internal static string ProductListed = "Ürünler listelendi";

        //direk sınıf adıyla çağıralım newlemeyelim diye static yaptık sınıfımızı.
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
    }
}
