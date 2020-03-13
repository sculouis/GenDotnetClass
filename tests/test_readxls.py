# encoding:UTF-8 
import pytest
from Library.ReadXls import ReadXls 

class TestXls:
    xlsObj = ReadXls(filename = 'templates/費用模組_v1.0.xlsx')
    
    def test_sheetNameGreateThanZero(self):
        print(f"\nsheet數： {len(self.xlsObj.getSheetNames())}") 
        for name in self.xlsObj.getSheetNames():
            print(f"{name}")

        assert len(self.xlsObj.getSheetNames()) > 0

    @pytest.mark.skip(reason="skip this")
    def test_getSheetData(self):
        # xlsObj = ReadXls(filename = 'templates/費用模組_v1.0.xlsx')
        for name in self.xlsObj.getSheetNames():
            print(f"sheet name:{name}")
            for row in self.xlsObj.getSheetData(name):
                print(row)

    @pytest.mark.skip(reason="skip this")
    def test_getFieldTiyle(self):
        # xlsObj = ReadXls(filename = 'templates/費用模組_v1.0.xlsx')
        print(self.xlsObj.fieldTitle('FormMaster',3))

    def test_getRows(self):
        # xlsObj = ReadXls(filename = 'templates/費用模組_v1.0.xlsx')
        for name in self.xlsObj.getSheetNames():
            print(f"sheet name:{name}")
            print(self.xlsObj.GetRows('FormMaster',self.xlsObj.fieldTitle(name,3)))