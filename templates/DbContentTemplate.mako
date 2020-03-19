using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MyNameSpace
{

    public class MyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyDB.db")
        }
        % for tableName in TableNames:
            ${dbset(tableName)}
        % endfor
    }
}

    <%def name="dbset(tableName)">
        public DbSet<${tableName}> ${tableName} { get; set; }
    </%def>