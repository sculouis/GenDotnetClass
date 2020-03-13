import pytest
from Library.ReadXls import ReadXls 
from Library.GenCshapeClass import GenCshapeClass
import sys

class TestGen:
    xlsObj = ReadXls(filename = 'templates/tableStructure.xlsx')    

    def test_genClass(self):
        sys.path.append('Library/GenCshapeClass.py')
        genClass = GenCshapeClass('templates','FormMaster')
        fieldTitles = self.xlsObj.fieldTitle('FormMaster',3)
        rows = self.xlsObj.GetRows('FormMaster',fieldTitles)
        genClass.GenCSFile(rows)