using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MyNameSpace
{

    public class MyDBContext : DbContext
    {
        % for tableName in TableNames:
            ${dbset(tableName)}
        % endfor
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyDB.db")
        }
    }
}

    <%def name="dbset(tableName)">
        public DbSet<${tableName}> ${tableName} { get; set; }
    </%def>