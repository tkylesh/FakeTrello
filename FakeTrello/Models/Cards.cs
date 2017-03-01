using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Cards
    {
        [Key]
        public int CardId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int CardUserId { get; set; }

        public int CardListId { get; set; }

        public int CardBoardId { get; set; }
    }
}