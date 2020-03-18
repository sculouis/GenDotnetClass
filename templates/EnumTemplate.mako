using System;
namespace MyNameSpace
{
    public enum ${fieldName} 
    {
        % for key,value in enumDicts.items():
        ${key} = ${value}
        % endfor
    }
}