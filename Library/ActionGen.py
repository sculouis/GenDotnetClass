import os
import os.path
from os import path

class ActionGen:
    """組合各元件執行商務邏輯"""
    def __init__(self,Xls,Gen,GenEnum,FileAccess):
        """設定template的目錄"""
        self.Xls=Xls
        self.Gen=Gen
        self.GenEnum=GenEnum
        self.File = FileAccess

    def run(self):
        """執行產生Code First Class"""
        for sheetName in self.Xls.getSheetNames():
            rows = self.Xls.GetRows(sheetName)
            # 若class目錄不存在則建立
            if (not path.exists(self.Gen.classDir)):
                os.mkdir(self.Gen.classDir)      

            # 產生Model Class
            self.Gen.GenCSFile(sheetName,rows)   
            self.File.Save(self.Gen.fileName,self.Gen.content)      
            # 產生Enum
            self.GenEnum.GenEnumCSFile(rows)
            self.File.Save(self.GenEnum.fileName,self.GenEnum.content)   
            print(self.GenEnum.content)   
        #  查看產生的DotNetClass
        self.File.showFilesContent()
 