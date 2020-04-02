import subprocess
from pathlib import Path
import shutil
from os import chdir
import os  
import shutil  

from Library.Dotnet import Command,ProjectKind,Package

class ShellContainer:
    def ShellCmd(self,cmd):
        process = subprocess.Popen(cmd, 
                            stdout=subprocess.PIPE,
                            universal_newlines=True)

        while True:
            output = process.stdout.readline()
            print(output.strip())
            # Do something else
            return_code = process.poll()
            if return_code is not None:
                # print('RETURN CODE', return_code)
                # Process has finished, read rest of the output 
                for output in process.stdout.readlines():
                    print(output.strip())
                break

    def RemoveFolder(self,path):
        try:
            shutil.rmtree(path)
        except OSError as e:
            print(e)
        else:
            print("The directory is deleted successfully")

    def CreateProject(self,projectName,ProjectKind):
        chdir('/Users/louischen/WorkSpace')
        p = Path()
        print(f'work path:{p.cwd()}')
        arg = ['dotnet',Command.NEW.value,ProjectKind.value, '-n', projectName]
        ShellCmd(arg)

    def RemoveProject(self,projectName):
        chdir('/Users/louischen/WorkSpace')
        p = Path()
        print(f'work path:{p.cwd()}')
        chdir(projectName)
        p = Path()
        print(f'work path:{p.cwd()}')
        RemoveFolder(p.absolute())

    def CopyFolder(self):    
        # path  
        path = '/Users/louischen/WorkSpace'
        # List files and directories  
        print("Before copying file:")  
        print(os.listdir(path))  
        # Source path  
        src = '/Users/louischen/WorkSpace/CodeGen/GenDotnetClass/Models'
        # Destination path  
        dest = '/Users/louischen/WorkSpace/DataAccess/Models'
        # Copy the content of  
        # source to destination  
        # using shutil.copy() as parameter 
        destination = shutil.copytree(src, dest, copy_function = shutil.copy)  

        # Source path  
        src = '/Users/louischen/WorkSpace/CodeGen/GenDotnetClass/Interfaces'
        # Destination path  
        dest = '/Users/louischen/WorkSpace/DataAccess/Interfaces'
        # Copy the content of  
        # source to destination  
        # using shutil.copy() as parameter 
        destination = shutil.copytree(src, dest, copy_function = shutil.copy)  

        # Source path  
        src = '/Users/louischen/WorkSpace/CodeGen/GenDotnetClass/Repository'
        # Destination path  
        dest = '/Users/louischen/WorkSpace/DataAccess/Repository'
        # Copy the content of  
        # source to destination  
        # using shutil.copy() as parameter 
        destination = shutil.copytree(src, dest, copy_function = shutil.copy)  


            
        # List files and directories  
        # in "C:/Users / Rajnish / Desktop / GeeksforGeeks"  
        print("After copying file:")  
        print(os.listdir(path))  
        # Print path of newly  
        # created file  
        print("Destination path:", destination) 

    def AddPackage(self,projectName,package,packageName,version):
        chdir(projectName)
        p = Path()
        print(f'work path:{p.cwd()}')
        arg = ['dotnet',package.value,'package',packageName,'--version',version]
        ShellCmd(arg)

    def SetupClassLib(self,projectName):    
        CreateProject(projectName,ProjectKind.CLASSLIB)
        CopyFolder()
        packageName = "Microsoft.EntityFrameworkCore.SqlServer"
        version = "3.1.3"
        AddPackage(projectName,Package.ADD,packageName,version)
