namespace baitap2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOA")]
    public partial class KHOA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaKhoa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string TenKhoa { get; set; }
    }
}
