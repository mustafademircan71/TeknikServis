using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeknikServis.Model.ViewModels.AdminPanel
{
    public class ServiceUpdateVm
    {
        public int Id { get; set; }
        //-------------------------------------------------
        [Required(ErrorMessage = "Ad Soyad Boş Bırakılamaz")]
        [MinLength(2, ErrorMessage = "Ad Soyad En Az İki Karakterden Oluşmalıdır.")]
        public string FullName { get; set; }
        //----------------------------------------------------
        [Required(ErrorMessage = "Marka Boş Bırakılamaz")]
        [MinLength(2, ErrorMessage = "Marka En Az İki Karakterden Oluşmalıdır.")]
        public string Brand { get; set; }
        //----------------------------------------------------------
        [Required(ErrorMessage = "Model Boş Bırakılamaz")]
        [MinLength(2, ErrorMessage = "Model En Az İki Karakterden Oluşmalıdır.")]
        public string Model { get; set; }
        //-----------------------------------
        public int FaultId { get; set; }
        public int DeviceStatusId { get; set; }
        public int CustomerTypeId { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
