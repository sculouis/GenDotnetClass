<%namespace file="UsingTemplate.mako" import="*"/>\
${using()}\
namespace DataAccess
{
    public class ${TableName} 
    {
        % for row in mapRows:
        /// <summary> 
        /// ${row.localFieldName} 
        /// </summary> \
        ${fieldDefine(row)}
        % endfor
        % for innerTable in innerTables:
        public List<${innerTable['slave']}> ${innerTable['slave']} {get;set;}    
        % endfor
    }


}

<%def name="fieldDefine(row)" buffered="True">
        % if (row.type == 'varchar') or (row.type == 'nvarchar'):
        [Column(TypeName="${row.type}(${row.length})")] 
        public string ${row.fieldName} { get; set; }
        % elif row.type == 'bit':
        public bool ${row.fieldName} { get; set; }
        % elif row.type == 'decimal':
        [Column(TypeName = "decimal(${row.length})")] 
        public decimal ${row.fieldName} { get; set; }
        % elif row.type == 'bigInt':
        public Int64 ${row.fieldName} { get; set; }
        % elif row.type == 'datetime':
        public DateTime ${row.fieldName} { get; set; }
        % else:
        public ${row.type} ${row.fieldName} { get; set; }
        % endif
        % if row.fkTable != None:
        public ${row.fkTable} ${row.fkTable} {get;set;}    
        % endif
</%def>