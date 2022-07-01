using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [Display(Name = "Oyun Adı")]
        [StringLength(50)]
        public string GameName { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Range(0, 10)]
        public float Point { get; set; }
        [Range(1990, 2022)]
        public int Year { get; set; }
        public string CoverPhoto { get; set; }

        // Developer, each game have a developer
        public int DeveloperId { get; set; }
        public virtual Developer Developer { get; set; }

        // Category, each game have a category
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }



        // Comments, each game can have between zero and infinite comments
        public ICollection<Comment> Comments { get; set; }

        // Gallery, each game can have between zero and infinite photos
        public ICollection<GameGallery> GameGalleries { get; set; }

    }
}
