using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Developer
    {
        [Key]
        public int DeveloperId { get; set; }
        [StringLength(30)]
        public string DeveloperCompanyName { get; set; }
        public string Logo { get; set; }

        // Game, A developer can have between 0 and infinite game
        public ICollection<Game> Games { get; set; }
    }
}
