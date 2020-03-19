import os
from os import listdir
from os.path import isfile, isdir, join
from os import path


class FileAccess:

    def __init__(self,config):
        self.config = config

    # 若class目錄不存在則建立
    def checkPath(self,myPath):
        if (not path.exists(myPath)):
            os.mkdir(myPath)      

    def DelFile(self,fileName):            
        if os.path.exists(fileName):
            os.remove(fileName)

    def Save(self,fileName,content):
        """設定存檔的檔名"""
        f= open(fileName,"w+")
        f.write(content)
        f.close()

    def showFilesContent(self):    
        # os.chdir("..")
        mypath =  f'{os.getcwd()}/{self.config.get("classDir")}' 
        # print(mypath + "\" + Configs.config.get("classDir"))
        # 取得所有檔案與子目錄名稱
        files = listdir(mypath)
        # 以迴圈處理
        for f in files:
            # 產生檔案的絕對路徑
            fullpath = join(mypath, f)
            # 判斷 fullpath 是檔案還是目錄
            if isfile(fullpath):
                log = open(fullpath, "r")
                for line in log:
                    print(line)
            elif isdir(fullpath):
                print("目錄：", f)      

if __name__ == "__main__":
    readFile = FileAccess()
    readFile.test_showDetail()
