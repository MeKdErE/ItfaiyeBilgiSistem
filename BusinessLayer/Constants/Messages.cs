using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Constants
{
    public static class Messages
    {
        //Kullanıcı Mesajları
        public static string UserAddSuccess = "Kullanıcı Ekleme İşlemi Başarılı.";
        public static string UserAddError = "Kullanıcı Ekleme İşlemi Başarısız.";
        public static string GetUserByMailSuccess = "Mail Adresine Göre Arama İşlemi Başarılı.";
        public static string GetUserByMaillError = "Mail Adresine Göre Arama İşlemi Başarısız.";
        public static string GetUserByUsernameSuccess = "Kullanıcı Adına Göre Arama İşlemi Başarılı.";
        public static string GetUserByUsernameError = "Kullanıcı Adına Göre Arama İşlemi Başarısız.";

        //Yetki Mesajları
        public static string OperationClaimDeleteSuccess = "Yetki Türü Silme İşlemi Başarılı";
        public static string OperationClaimDeleteError = "Yetki Türü Silme İşlemi Başarısız!!";
        public static string OperationClaimAddSuccess="Yetki Türü Ekleme İşlemi Başarılı";
        public static string OperationClaimAddError="Yetki Türü Ekleme İşlemi Başarısız!!";
        public static string OperationClaimUpdateSuccess="Yetki Türü Güncelleme İşlemi Başarılı";
        public static string OperationClaimUpdateError = "Yetki Türü Ekleme İşlemi Başarısız!!";
        public static string OperationClaimAllListSuccess = "Tüm Yetkilerin Listeleme İşlemi Başarılı.";
        public static string OperationClaimAllListError = "Tüm Yetkilerin Listeleme İşlemi Başarısız!!";
        public static string OperationClaimGetByNameSuccess = "İsme Göre Yetki Arama İşlemi Başarılı.";
        public static string OperationClaimGetByNameError = "İsme Göre Yetki Arama İşlemi Başarısız!!";
        public static string OperationClaimGetByIdSuccess = "ID'ye Göre Yetki Arama İşlemi Başarılı.";
        public static string OperationClaimGetByIdError = "ID'ye Göre Yetki Arama İşlemi Başarısız!!";

        //Kullanıcı Yetki Atama Mesajları
    }
}
