from dependency_injector import providers, containers
from Library.ReadXls import ReadXls
from Library.GenCshape import GenCshape 
from Library.ActionGen import ActionGen
from Library.ReadFile import ReadFile

class Configs(containers.DeclarativeContainer):
    config = providers.Configuration('config')
    
class Xls(containers.DeclarativeContainer):
    xls_client = providers.Singleton(ReadXls, Configs.config)

class GenClass(containers.DeclarativeContainer):
    gen_client = providers.Singleton(GenCshape, Configs.config)

class FileShow(containers.DeclarativeContainer):
    file_client = providers.Singleton(ReadFile, Configs.config)

class Action(containers.DeclarativeContainer):
    action = providers.Factory(ActionGen,Xls=Xls.xls_client,Gen=GenClass.gen_client,FileShow=FileShow.file_client)
