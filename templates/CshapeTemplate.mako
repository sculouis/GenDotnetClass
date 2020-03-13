using System;
namespace MyNameSpace
{
    public class ${TableName}
    {
        % for row in mapRows:
        /// <summary>
        /// ${row['localName'].decode()}
        /// </summary>
        public ${row['type']} ${row['fieldName']} { get; set; }
        
        % endfor
    }
}