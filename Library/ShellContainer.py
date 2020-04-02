import subprocess
from pathlib import Path
import shutil
from os import chdir
import os  
import shutil  
from Library.Dotnet import Command,ProjectKind,Package

class ShellContainer:
    def __init__(self):
        super().__init__()

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

    def NewProject(self,mainPath,projectName,ProjectKind):
        chdir(mainPath)
        p = Path()
        print(f'work path:{p.cwd()}')
        arg = ['dotnet',Command.NEW.value,ProjectKind.value, '-n', projectName]
        self.ShellCmd(arg)

    def RemoveProject(self,projectName):
        chdir('/Users/louischen/WorkSpace')
        p = Path()
        print(f'work path:{p.cwd()}')
        chdir(projectName)
        p = Path()
        print(f'work path:{p.cwd()}')
        RemoveFolder(p.absolute())

    def CopyFolder(self,mainPath,src,dest):    
        # List files and directories  
        print("Before copying file:")  
        print(os.listdir(mainPath))  
        destination = shutil.copytree(src, dest, copy_function = shutil.copy)  
        # List files and directories  
        # in "C:/Users / Rajnish / Desktop / GeeksforGeeks"  
        print("After copying file:")  
        print(os.listdir(mainPath))  
        # Print path of newly  
        # created file  
        print("Destination path:", destination) 

    def AddPackage(self,projectName,package,packageName,version):
        chdir(projectName)
        p = Path()
        print(f'work path:{p.cwd()}')
        arg = ['dotnet',package.value,'package',packageName,'--version',version]
        self.ShellCmd(arg)

    def PrepareDotnetProject(self,mainPath):
        # Source path  
        src = f'{mainPath}/CodeGen/GenDotnetClass/Models'
        # Destination path  
        dest = f'{mainPath}/MyWebProject/DataAccess/Models'
        self.CopyFolder(mainPath,src,dest)

        # Source path  
        src = f'{mainPath}/CodeGen/GenDotnetClass/Interfaces'
        # Destination path  
        dest = f'{mainPath}/MyWebProject/DataAccess/Interfaces'
        self.CopyFolder(mainPath,src,dest)

        # Source path  
        src = f'{mainPath}/CodeGen/GenDotnetClass/Repository'
        # Destination path  
        dest = f'{mainPath}/MyWebProject/DataAccess/Repository'
        self.CopyFolder(mainPath,src,dest)

    def copytree(self, src, dst, symlinks=False, ignore=None):
        for item in os.listdir(src):
            s = os.path.join(src, item)
            d = os.path.join(dst, item)
            if os.path.isdir(s):
                shutil.copytree(s, d, symlinks, ignore)
            else:
                shutil.copy2(s, d)

    def PrepareMvcProject(self,mainPath):
        # Source path  
        src = f'{mainPath}/CodeGen/GenDotnetClass/Controllers'
        # Destination path  
        dest = f'{mainPath}/MyWebProject/MyWeb/Controllers'
        self.copytree(src,dest)

    def GenClassLibProject(self,mainPath,projectName): 
        self.NewProject(mainPath,projectName,ProjectKind.CLASSLIB)
        packageName = "Microsoft.EntityFrameworkCore.SqlServer"
        version = "3.1.3"
        projectName = "DataAccess"
        self.AddPackage(f'{mainPath}/{projectName}',Package.ADD,packageName,version)

    def GenWebMVCProject(self,mainPath,projectName): 
        self.NewProject(mainPath,projectName,ProjectKind.MVC)
        # packageName = "Microsoft.EntityFrameworkCore.SqlServer"
        # version = "3.1.3"
        # projectName = "DataAccess"
        # self.AddPackage(f'{mainPath}/{projectName}',Package.ADD,packageName,version)

    def CreateSln(self,mainPath):
        chdir(mainPath)
        arg = ['dotnet',Command.ADD.value,'MyWeb/MyWeb.csproj','reference','DataAccess/DataAccess.csproj']
        self.ShellCmd(arg)

        arg = ['dotnet',Command.NEW.value,ProjectKind.SLN.value]
        self.ShellCmd(arg)

        arg = ['dotnet',ProjectKind.SLN.value, Command.ADD.value, 'DataAccess/DataAccess.csproj'] 
        self.ShellCmd(arg)

        arg = ['dotnet',ProjectKind.SLN.value, Command.ADD.value, 'MyWeb/MyWeb.csproj'] 
        self.ShellCmd(arg)
