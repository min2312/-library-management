using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_Final.DTO
{
    [Table("Book")]
    public class Book
    {
        [Key, Column(Order = 0)]
        [Required]
        public string MaSach {  get; set; }
        public string NameSach { get; set; }
        public DateTime NgayMuon { get; set; }
        [Key, Column(Order = 1)]
        public string MSSV {  get; set; }
        [ForeignKey(nameof(MSSV))]
        public  virtual User User {  get; set; }
    }
}
