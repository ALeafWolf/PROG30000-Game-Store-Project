using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team_WASD___Game_Store_Stock_Management_System.Models
{
    [Table("tblGame")]
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Tite { get; set; }
        public Publisher Publisher { get; set; }
        public Developer Developer { get; set; }

        public Genre Genre { get; set; }

        public Platform Platform { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int InStockAmount { get; set; }
    }
}
