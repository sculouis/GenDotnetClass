import os
from os import listdir
from os.path import isfile, isdir, join
import pathlib

class ReadFile:

    def __init__(self,config):
        self.config = config

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
    
    def hello_world(self):
        print(os.path.abspath(os.curdir))
        os.chdir("..")
        print(os.path.abspath(os.curdir))

if __name__ == "__main__":
    readFile = ReadFile()
    readFile.test_showDetail()
