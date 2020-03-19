using System;
namespace MyNameSpace
{
    % for item in enumDicts:
    public enum ${item['fieldName']} 
    {
        % for key,value in item['enumDict'].items():
        ${key} = ${value},
        % endfor
    }
    
    % endfor
}