using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class GameGallery
    {
        [Key]
        public int GalleryId { get; set; }
        public string GameImage { get; set; }
        // Game, A game can have between 0 and infinite photo
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
    }
}
