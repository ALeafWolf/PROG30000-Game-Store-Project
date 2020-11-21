using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team_WASD___Game_Store_Stock_Management_System.Models
{
    [Table("tblDeveloper")]
    public class Developer
    {
        [Key]
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
    }
}
