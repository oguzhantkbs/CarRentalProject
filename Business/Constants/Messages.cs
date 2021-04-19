using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarDescInvalid = "Araç Açıklaması Geçersiz";
        public static string CarsListed = "Arabalar Listelendi";

        public static string RentalsListed = "Kiralıklar Listelendi";
        public static string RentalAdded = "Kiralama Eklendi";
        public static string RentalNotComeBack = "Araç Geri Getirilmedi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string RentalDeleted = "Kiralama Silindi";

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";

        public static string ColorAdded = "Renk Eknlendi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorDeleted = "Renk Silindi";

        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerAdded = "Müşteriler Eklendi";
        public static string CustomerUpdated = "Müşteriler Güncellendi";
        public static string CustomerDeleted = "Müşteriler Silindi";

        public static string UserUpdated = "Kullnıcılar Güncellendi";
        public static string UserDeleted = "Kullanıcılar Silindi";
        public static string UserAdded = "Kullanıcılar Eklendi";
        public static string UsersListed = "Kullanıcılar Listelendi";

        public static string CarDeleted { get; internal set; }
        public static string ColorsListed { get; internal set; }
        public static string RentalUpdated { get; internal set; }
    }
}
