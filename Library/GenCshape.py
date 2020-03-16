from mako.template import Template
from mako.lookup import TemplateLookup
import os
import os.path
from os import path


class GenCshape:
    def __init__(self,config):
        """設定template的目錄"""
        self.config = config
        templateDir = self.config.get('templateDir')
        self.classDir = self.config.get('classDir')
        self.tableName = ""
        self.fileName = ""
        self.mylookup = TemplateLookup(directories=[templateDir], input_encoding='utf-8', encoding_errors='replace')
        self.ClassResult = ""
        
    def RenderCS(self,data=[]):
        """設定template的檔案 
           設定寫入版型的變數 
        """
        tempFileName = self.config.get('tempFileName')
        mytemplate = self.mylookup.get_template(tempFileName)
        self.ClassResult = mytemplate.render(TableName = self.tableName,mapRows=data)

    def DelFile(self):            
        if os.path.exists(self.fileName):
            os.remove(self.fileName)

    def Save(self):
        """設定存檔的檔名"""
        f= open(self.fileName,"a+")
        f.write(self.ClassResult)
        f.close()

    def GenCSFile(self,tableName,maprows):
        self.tableName = tableName
        self.RenderCS(maprows)
        self.fileName = f"{self.classDir}/{self.tableName}.cs"
        if (not path.exists(self.classDir)):
            os.mkdir(self.classDir)      
        self.DelFile()
        self.Save()