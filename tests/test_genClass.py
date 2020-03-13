import pytest
from Library.ReadXls import ReadXls 
from Library.GenCshape import GenCshape
import sys

class TestGen:
    xlsObj = ReadXls(filename = 'templates/tableStructure.xlsx')    

    def test_genClass(self):
        genClass = GenCshape('templates','FormMaster')
        fieldTitles = self.xlsObj.fieldTitle('FormMaster',3)
        rows = self.xlsObj.GetRows('FormMaster',fieldTitles)
        genClass.GenCSFile(rows)