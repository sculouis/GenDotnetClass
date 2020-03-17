using System;
namespace MyNameSpace
{
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