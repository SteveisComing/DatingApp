using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{//必須繼承DbContext
    public class DataContext:DbContext
    {//不知道在寫三小
        public DataContext(DbContextOptions options):base(options)
        {


        }

        public DbSet<AppUser> Users{get;set;}
    }
}