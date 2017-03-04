using FakeTrello.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FakeTrello.DAL
{
    public class FakeTrelloContext : ApplicationDbContext
    {
        public virtual DbSet<TrelloUser> TrelloUsers { get; set; }
    }
}