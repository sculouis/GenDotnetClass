import pytest
import sys
from Library.Container import Configs,Action

class TestGen:

    def test_genClass(self):
        Configs.config.override({
            "filename": "templates/tableStructure.xlsx",
            "templateDir": "templates",
            "tempFileName": "CshapeTemplate.mako",
            "classDir":"CsClass"            
        })
        action = Action.action()
        action.run()    