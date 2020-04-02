import pytest
from Library.ShellContainer import ShellContainer

class TestShell:
    # @pytest.mark.skip(reason="skip this")
    def test_prepareFolder(self):
        mainPath = '/Users/louischen/WorkSpace'
        shell = ShellContainer()
        shell.GenClassLibProject(mainPath,'DataAccess')

        # copy dataaccess files
        shell.PrepareDotnetProject(mainPath)

        # delete dataaccess files
        # projectName = f"{mainPath}/DataAccess"
        # shell.RemoveFolder(projectName)
