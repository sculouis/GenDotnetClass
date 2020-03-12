import pytest
from Library.ReadXls import ReadXls 

class TestXls:
    def test_sheetNameGreateThanZero(self):
        xlsObj = ReadXls(filename = 'templates/費用模組_v1.0.xlsx')
        print(len(xlsObj.getSheetNames())) 
        assert len(xlsObj.getSheetNames()) > 0