using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenThiThuyHang500.Models
{
    public class NTTH0500
    {
        [Key]
        [StringLength(20)]
        [Display(Name ="Mã")]
        public string NTTHID {get; set; }
        [StringLength (50)]
        [Display(Name ="Tên")]

        public string NTTHName {get; set; }
        [Display(Name ="Giới Tính")]
        public Boolean NTTHGender {get;set;}

    }
}