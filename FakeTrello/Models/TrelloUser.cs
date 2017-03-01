using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    //uses entity framework
    //Entity is out Object Relational Mapper (ORM)
    public class TrelloUser
    {
        //Denote primary key using "data annotation"
        //only applies to directly following property
        [Key]
        public int TrelloUserId { get; set; } //Primary Key

        //how to appy multiple annotations to single property
        //if property doesn't abide by annotations an exception is thrown
        [MinLength(10)]
        [MaxLength(60)]
        public string Email { get; set; }

        [MaxLength(60)]
        public string UserName { get; set; }

        [MaxLength(60)]
        public string Fullname { get; set; }

        public ApplicationUser BaseUser { get; set; } //1 to 1 Relationship


        //navigation property
        public List<Board> Boards { get; set; } // 1 to Many (boards) Relationship
    }
}