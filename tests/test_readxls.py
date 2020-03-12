import pytest
from Library.ReadXls import ReadXls 

class TestXls:
    def test_sheetNameGreateThanZero(self):
        xlsObj = ReadXls(filename = 'templates/tableDefine_v1.0.xlsx')
        print(f"\nsheet數： {len(xlsObj.getSheetNames())}") 
        assert len(xlsObj.getSheetNames()) > 0