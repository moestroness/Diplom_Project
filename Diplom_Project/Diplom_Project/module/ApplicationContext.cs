using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Diplom_Project.module
{
    public class ApplicationContext :DbContext
    {
        private string _databasePath;
        public DbSet<Theory>Theory { get; set; }
        public DbSet<Practic> Practic {  get; set; }
        public ApplicationContext(string databasePath)
        {
            _databasePath = databasePath;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
