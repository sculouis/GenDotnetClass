# encoding:UTF-8 
import pytest
from Library.ReadXls import ReadXls 

class TestXls:
    def test_sheetNameGreateThanZero(self):
        xlsObj = ReadXls(filename = 'templates/費用模組_v1.0.xlsx')
        print(f"\nsheet數： {len(xlsObj.getSheetNames())}") 
        for name in xlsObj.getSheetNames():
            print(f"{name}")

        assert len(xlsObj.getSheetNames()) > 0

    @pytest.mark.skip(reason="skip this")
    def test_getSheetData(self):
        xlsObj = ReadXls(filename = 'templates/費用模組_v1.0.xlsx')
        for name in xlsObj.getSheetNames():
            print(f"sheet name:{name}")
            for row in xlsObj.getSheetData(name):
                print(row)

    @pytest.mark.skip(reason="skip this")
    def test_getFieldTiyle(self):
        xlsObj = ReadXls(filename = 'templates/費用模組_v1.0.xlsx')
        print(xlsObj.fieldTitle('FormMaster',3))

    def test_getRows(self):
        xlsObj = ReadXls(filename = 'templates/費用模組_v1.0.xlsx')
        for name in xlsObj.getSheetNames():
            print(f"sheet name:{name}")
            print(xlsObj.GetRows('FormMaster',xlsObj.fieldTitle(name,3)))