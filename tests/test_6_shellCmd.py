import pytest
import yaml
from Library.ShellContainer import ShellContainer

class RunShell:
    
    # @pytest.mark.skip(reason="skip this")
    def test_removeFolder(self):
        shell = ShellContainer()
        projectName = "/Users/louischen/WorkSpace/DataAccess"
        shell.RemoveFolder(projectName)
