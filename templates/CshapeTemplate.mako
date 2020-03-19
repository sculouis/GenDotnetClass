using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MyNameSpace
{

    public class MyDBContext : DbContext
    {
        public DbSet<${TableName}> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        }
    }

    
    public class ${TableName} 
    {
        % for row in mapRows:
        /// <summary> 
        /// ${row.localFieldName} 
        /// </summary> 
        % if (row.type == 'varchar') or (row.type == 'nvarchar'):
        [Column("${row.fieldName}", TypeName="${row.type}")] 
        [MaxLength(${row.length})]
        public string ${row.fieldName} { get; set; }
        % else:
        public ${row.type} ${row.fieldName} { get; set; }
        % endif
        
        % endfor
    }


}