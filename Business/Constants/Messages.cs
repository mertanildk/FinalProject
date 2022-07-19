using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{//CONSTANTS = SABİTLER = MESSAGES OLUŞTURDUK, BURDAKİ MESAJLARIMIZ NORTWINDE ÖZEL OLDUĞU İÇİN CORE İÇİNE ALMADIK.
    public static class Messages
    {
        public static string ProductAdded = "Product is added";
        public static string ProductNameInValid = "Product name is not valid";
        public static string MaintenanceTime = "System in Maintenance Time";
        public static string ProductsListed="Products are on the list";
        internal static string ProductCountOfCategoryError="Category count is full";
        internal static string ProductNameAlreadyExists= "Product Name Already Exists";
        internal static string CategoryLimitExceded= "Category Limit Exceded";
    }
}
