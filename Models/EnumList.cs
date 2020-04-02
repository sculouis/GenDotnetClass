using System;
namespace MyNameSpace
{
    public enum ExpenseKind 
    {
        PREPAY = 1,
        PO_STD = 2,
        PO_CM_RETURN = 3,
        PO_CM_EXP = 4,
        NPO_CM_EXP = 5,
        NPO_DONATE_EXP = 6,
        EMP_TRAVEL_EXP = 7,
        EMP_OTHER_EXP = 8,
        EMP_MGR_EXP = 9,
        EA_MISC_EXP = 10,
        EA_SPECIFIC_EXP = 11,
        ESP_EXP = 12,
        ESP_CM_EXP = 13,
        ESP_DONATE_EXP = 14,
    }
    
    public enum FormStatus 
    {
        Template = 0,
        Save = 1,
        StartProcess = 2,
        Closed = 3,
    }
    
}