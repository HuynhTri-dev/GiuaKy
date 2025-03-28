using System.ComponentModel.DataAnnotations;

namespace GiuaKy.Models
{
    public class MonHoc
    {

        [MaxLength(10)]
        public string MaMH { get; set; }

        [MaxLength(100)]
        public string TenMH { get; set; }
        public byte SoTC { get; set; }

        public ICollection<DiemThi> DiemThis { get; set; }
    }
}
