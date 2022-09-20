using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        public static string ProductCountOfCategoryError="Category count is full";
        public static string ProductNameAlreadyExists= "Product Name Already Exists";
        public static string CategoryLimitExceded= "Category Limit Exceded";
        public static string AuthorizationDenied= "You have no authority.";
        public static string UserRegistered="User Registered";
        public static string UserNotFound="User not Found";
        public static string PasswordError="Password Error";
        public static string SuccessfulLogin= "Successfuly Login";
        public static string AccessTokenCreated= "Access Token Created";
        public static string UserAlreadyExists= "User Already Exists";
    }
}
