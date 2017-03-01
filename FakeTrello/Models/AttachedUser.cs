using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class AttachedUser
    {
        [Key]
        public int AttachedUserId { get; set; }

        public int CardId { get; set; }

        public int CardCreatorUserId { get; set; }

        public int BoardId { get; set; }

        public int ListId { get; set; }
    }
}