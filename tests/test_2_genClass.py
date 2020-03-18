import pytest
import sys
from Library.Container import Configs,Action

class TestGen:

    # @pytest.mark.skip(reason="skip this")
    def test_genClass(self):
        Configs.config.override({
            "filename": "templates/tableStructure.xlsx",
            "templateDir": "templates",
            "tempFileName": "CshapeTemplate.mako",
            "tempEnumFileName": "EnumTemplate.mako",
            "classDir":"CsClass"            
        })
        action = Action.action()
        action.run()  

