using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [StringLength(500)]
        public string CommentDescription { get; set; }

        // Game, A game can have between 0 and infinite comment
        public int GameId { get; set; }
        public virtual Game Game { get; set; }

    }
}
