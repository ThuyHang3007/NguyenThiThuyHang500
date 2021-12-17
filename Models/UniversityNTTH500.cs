using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenThiThuyHang500.Models
{
    public class UniversityNTTH500
    {
        [Key]
        [StringLength(20)]
        [Display(Name ="Mã trường")]
        public string UniversityID {get; set; }
        [StringLength (50)]
        [Display(Name ="Tên trường")]

        public string UniversityName {get; set; }

    }
}