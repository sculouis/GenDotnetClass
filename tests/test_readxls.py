# encoding:UTF-8 
import pytest
from Library.ReadXls import ReadXls 

class TestXls:
    def test_sheetNameGreateThanZero(self):
        xlsObj = ReadXls(filename = 'templates/tableDefine_v1.0.xlsx')
        print(f"\nsheet數： {len(xlsObj.getSheetNames())}") 
        for name in xlsObj.getSheetNames():
            print(f"\n {name}")
            
        assert len(xlsObj.getSheetNames()) > 0

