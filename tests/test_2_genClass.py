import pytest
import yaml
from Library.Container import Configs,Action

class TestGen:
    def test_1_start(self):
        with open('tests/app.yaml', 'r') as stream:
            data = yaml.load(stream, Loader=yaml.FullLoader)
        Configs.config.override(data)

    # @pytest.mark.skip(reason="skip this")
    def test_genClass(self):
        action = Action.action()
        action.genClass()

