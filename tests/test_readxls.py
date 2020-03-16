# encoding:UTF-8 
import pytest
from Library.Container import Configs,Xls

class TestXls:
    Configs.config.override({
        "filename": "templates/tableStructure.xlsx",
        "templateDir": "templates",
        "TableName": "FormMaster",
        "tempFileName": "CshapeTemplate.mako"            
    })
    xlsObj = Xls.xls_client()
    
    def test_sheetNameGreateThanZero(self):
        print(f"\nsheet數： {len(self.xlsObj.getSheetNames())}") 
        for name in self.xlsObj.getSheetNames():
            print(f"{name}")

        assert len(self.xlsObj.getSheetNames()) > 0

    @pytest.mark.skip(reason="skip this")
    def test_getSheetData(self):
        for name in self.xlsObj.getSheetNames():
            print(f"sheet name:{name}")
            for row in self.xlsObj.getSheetData(name):
                print(row)

    # @pytest.mark.skip(reason="skip this")
    def test_getFieldTiyle(self):
        print(self.xlsObj.fieldTitle('FormMaster',3))

    # @pytest.mark.skip(reason="skip this")
    def test_getRows(self):
        for sheetName in self.xlsObj.getSheetNames(['Index']):
            print(f"sheet name:{sheetName}")
            fieldTitles = self.xlsObj.fieldTitle(sheetName,3)
            for field in self.xlsObj.GetRows(sheetName):
                print(field)