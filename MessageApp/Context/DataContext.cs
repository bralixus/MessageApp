using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MessageApp.Models.DataBase;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MessageApp.Context
{
    public class DataContext:IdentityDbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DataContext() : base("DatabaseContext")
        {
           
        }
    }
}