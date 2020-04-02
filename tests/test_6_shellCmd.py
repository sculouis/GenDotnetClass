import pytest
from Library.ShellContainer import ShellContainer
from Library.FileAccess import FileAccess

class TestShell:
    fileAcces = FileAccess()
    mainPath = '/Users/louischen/WorkSpace'
    shell = ShellContainer()
    myProject = f'{mainPath}/MyWebProject'

    # @pytest.mark.skip(reason="skip this")
    def test_1_CreateFolder(self):
        self.fileAcces.checkPath(self.myProject)

    @pytest.mark.skip(reason="skip this")
    def test_2_RemoveFolder(self):
        # delete dataaccess files
        self.shell.RemoveFolder(self.myProject)

    # @pytest.mark.skip(reason="skip this")
    def test_3_prepareFolder(self):
        self.projectName = "DataAccess"
        self.shell.GenClassLibProject(self.myProject, self.projectName)
        # delete default Class1.cs
        self.fileAcces.DelFile(f'{self.myProject}/{self.projectName}/Class.cs')

        # copy codegen dataaccess files
        self.shell.PrepareDotnetProject(self.mainPath)

    # @pytest.mark.skip(reason="skip this")
    def test_4_prepareMVCFolder(self):
        self.projectName = "MyWeb"
        self.shell.GenWebMVCProject(self.myProject, self.projectName)
        # copy codegen control files
        self.shell.PrepareMvcProject(self.mainPath)

    # @pytest.mark.skip(reason="skip this")
    def test_5_CreateSln(self):
        # copy codegen control files
        self.shell.CreateSln(self.myProject)