using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakım zamanı.";
        public static string ProductsListed = "Ürünler başarılı bir şekilde listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride 10'dan fazla ürün olamaz.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı kayıt oldu.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Parola hatalı.";
        public static string SuccessfulLogin="Giriş başarılı.";
        public static string UserAlreadyExists="Kullanıcı zaten mevcut.";
        public static string AccessTokenCreated="Access token oluşturuldu.";
    }
}
