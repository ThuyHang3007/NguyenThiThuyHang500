using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenThiThuyHang500.Models
{
    public class UniversityNTTH500
    {
        [Key]
        [StringLength(20)]
        [Display(Name = "Mã Trường")]
        public string UniversityId { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên Trường")]

        public string UniversityName { get; set; }

    }
}