import pytest
from Library.ReadXls import ReadXls 
from Library.GenCshapeClass import GenCshapeClass

class TestGen:
    xlsObj = ReadXls(filename = 'templates/tableStructure.xlsx')    

    def test_genClass(self):
        genClass = GenCshapeClass('templates','FormMaster')
        fieldTitles = self.xlsObj.fieldTitle('FormMaster',3)
        rows = self.xlsObj.GetRows('FormMaster',fieldTitles)
        genClass.GenCSFile(rows)