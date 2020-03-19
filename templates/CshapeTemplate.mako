using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MyNameSpace
{    
    public class ${TableName} 
    {
        % for row in mapRows:
        /// <summary> 
        /// ${row.localFieldName} 
        /// </summary> 
        % if (row.type == 'varchar') or (row.type == 'nvarchar'):
        [Column(TypeName="${row.type}")] 
        [MaxLength(${row.length})]
        public string ${row.fieldName} { get; set; }
        % elif row.type == 'bit':
        public bool ${row.fieldName} { get; set; }
        % elif row.type == 'decimal':
        [Column(TypeName="decimal(${row.length})")] 
        public decimal ${row.fieldName} { get; set; }
        % else:
        public ${row.type} ${row.fieldName} { get; set; }
        % endif
        % if row.fkTable != None:
        public ${row.fkTable} ${row.fkTable} {get;set;}    
        % endif

        % endfor
        % for innerTable in innerTables:
        public List<${innerTable['slave']}> ${innerTable['slave']} {get;set;}    
        % endfor
    }


}