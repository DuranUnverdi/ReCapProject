using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string CarUpdated = "Araç ismi güncellendi";
        public static string CarUpdatedInvalid = "Araç bilgileri güncelleme işlemi geçersiz";

        internal static string CarsListed= "Listeleme Başarılı";
        internal static string MaintenanceTime="Sistem bakımda";
        public static string CarCountOfCategoryError="Bir markada en fazla 10 araç olabilir";
        public static string CarNameAlreadyExists="Açıklama alanları aynı olamaz";
        public static string BrandLimitExceded="Marka limiti aşıldığı için yeni kayıt yapılamıyor";
    }
}
