from dependency_injector import providers, containers
from Library.ReadXls import ReadXls
from Library.GenCshape import GenCshape 
from Library.GenEnumCs import GenEnumCs
from Library.ActionGen import ActionGen
from Library.FileAccess import FileAccess

class Configs(containers.DeclarativeContainer):
    config = providers.Configuration('config')
    
class Xls(containers.DeclarativeContainer):
    xls_client = providers.Singleton(ReadXls, Configs.config)

class GenClass(containers.DeclarativeContainer):
    gen_client = providers.Singleton(GenCshape, Configs.config)

class GenEnum(containers.DeclarativeContainer):
    genenum_client = providers.Singleton(GenEnumCs, Configs.config)

class FileAccess(containers.DeclarativeContainer):
    file_client = providers.Singleton(FileAccess)

class Action(containers.DeclarativeContainer):
    action = providers.Factory(ActionGen,Xls=Xls.xls_client,Gen=GenClass.gen_client,GenEnum = GenEnum.genenum_client ,FileAccess=FileAccess.file_client)
