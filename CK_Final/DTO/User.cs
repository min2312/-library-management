using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_Final.DTO
{
    [Table("User")]
    public class User
    {
        public User() 
        {
            this.Books = new HashSet<Book>();
        }
        [Key]
        [Required]
        public string MSSV { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime NS { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
