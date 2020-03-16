import pytest
import sys
from Library.Container import Configs,Action
from os import listdir
from os.path import isfile, isdir, join
import pathlib



class TestGen:

    @pytest.mark.skip(reason="skip this")
    def test_genClass(self):
        Configs.config.override({
            "filename": "templates/tableStructure.xlsx",
            "templateDir": "templates",
            "tempFileName": "CshapeTemplate.mako",
            "classDir":"CsClass"            
        })
        action = Action.action()
        action.run()  

    def test_showDetail(self):    
        mypath =  "C:\\Envs\\GenCode\\GenDotnetClass\\CsClass" 
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