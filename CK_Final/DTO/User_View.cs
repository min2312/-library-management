using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_Final.DTO
{
    public class User_View
    {
        public string MSSV { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; } 
        public DateTime NS {  get; set; }
        public string MaSach {  get; set; }
        public string NameSach {  get; set; }
        public DateTime NgayMuon { get; set; }
    }
}
