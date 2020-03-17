from dependency_injector import providers, containers
from Library.ReadXls import ReadXls
from Library.GenCshape import GenCshape

class Configs(containers.DeclarativeContainer):
    config = providers.Configuration('config')
    # other configs
    
class Clients(containers.DeclarativeContainer):
    xls_client = providers.Singleton(ReadXls, Configs.config)
    # other clients
    
class Readers(containers.DeclarativeContainer):
    class_generator = providers.Factory(GenCshape, client=Clients.xls_client)
    # other readers