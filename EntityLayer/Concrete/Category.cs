using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(20)]
        public string CategoryName { get; set; }
        [StringLength(20)]
        public string Color { get; set; }

        // Game, each category can have between 0 and infinite game
        public ICollection<Game> Games { get; set; }
    }
}
