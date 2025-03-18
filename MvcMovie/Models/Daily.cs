using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Daily")]
    public class DaiLy 
    {
        [Key]
        public required string MaDaiLy { get; set; } 
        public required string TenDaiLy { get; set; }
        public string? DiaChi { get; set; }
        public string? NguoiDaiDien { get; set; }
        public required string DienThoai { get; set; } 
        public required string MaHTPP { get; set; } 
    }
}