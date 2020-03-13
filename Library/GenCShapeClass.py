from mako.template import Template
from mako.lookup import TemplateLookup
import os

class GenCshapeClass:
    def __init__(self,templateDir = 'templates',TableName = ''):
        """設定template的目錄"""
        self.TableName = TableName
        self.mylookup = TemplateLookup(directories=[templateDir], input_encoding='utf-8', encoding_errors='replace')
        self.ClassResult = ""
        
    def RenderCS(self,tempFileName = "CshapeTemplate.mako",data=[]):
        """設定template的檔案 
           設定寫入版型的變數 
        """
        mytemplate = self.mylookup.get_template(tempFileName)
        self.ClassResult = mytemplate.render(TableName = self.TableName,mapRows=data)

    def DelFile(self,fileName=''):            
        if os.path.exists(fileName):
            os.remove(fileName)

    def Save(self,fileName = "docs/result.txt"):
        """設定存檔的檔名"""
        f= open(fileName,"a+")
        f.write(self.ClassResult)
        f.close()

    def GenCSFile(self,maprows):
        self.RenderCS("CshapeTemplate.mako", maprows)
        fileName = f"CsClass/{self.TableName}.cs"
        self.DelFile(fileName)
        self.Save(fileName)