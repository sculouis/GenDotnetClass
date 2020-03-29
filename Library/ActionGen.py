
class ActionGen:
    """組合各元件執行商務邏輯"""
    def __init__(self,Xls,Gen,GenEnum,GenControllers,GenInterface,GenRepository,FileAccess):
        """設定template的目錄"""
        self.Xls=Xls
        self.Gen=Gen
        self.GenEnum=GenEnum
        self.GenControllers=GenControllers
        self.GenInterface=GenInterface
        self.GenRepository=GenRepository
        self.File = FileAccess

    def genClass(self):
        """執行產生Code First Class"""
        self.File.checkPath(self.Gen.classDir)    
        sheetNames = self.Xls.getSheetNames()
        fkTables = self.Xls.GetFkTableNotNone()
        # 產生DBContent
        self.Gen.GenDBContentFile(sheetNames)   
        self.File.Save(self.Gen.dbContentFileName,self.Gen.dbContent)      

        for sheetName in sheetNames:
            rows = self.Xls.GetRows(sheetName)
            innerTables = [fkTable for fkTable in fkTables if fkTable['master'] == sheetName]

            # 產生Model Class
            self.Gen.GenCSFile(sheetName,rows,innerTables)   
            self.File.Save(self.Gen.fileName,self.Gen.content)      
            # 產生Enum
            self.GenEnum.GenEnumCSFile(rows)
            self.File.Save(self.GenEnum.fileName,self.GenEnum.content)   
        #  查看產生的DotNetClass
        # self.File.showFilesContent(self.Gen.classDir)
  
    def genControllers(self):
        """執行產生Asp.net Core Controllers"""
        self.File.checkPath(self.GenControllers.controllersDir)    
        sheetNames = self.Xls.getSheetNames()
        for sheetName in sheetNames:
            rows = self.Xls.GetRows(sheetName)
            # 產生Asp.net Core Controllers
            self.GenControllers.GenControllersFile(sheetName,rows)   
            self.File.Save(self.GenControllers.fileName,self.GenControllers.content)      

    def genInterface(self):
        """執行產生Asp.net Core Interface"""
        self.File.checkPath(self.GenInterface.interfaceDir)    
        sheetNames = self.Xls.getSheetNames()
        for sheetName in sheetNames:
            # 產生Asp.net Core Interface
            self.GenInterface.GenInterfaceFile(sheetName)   
            self.File.Save(self.GenInterface.fileName,self.GenInterface.content)      

    def genRepository(self):
        """執行產生Asp.net Core Repository"""
        self.File.checkPath(self.GenRepository.repositoryDir)    
        sheetNames = self.Xls.getSheetNames()
        for sheetName in sheetNames:
            # 產生Asp.net Core Repository
            self.GenRepository.GenRepositoryFile(sheetName)   
            self.File.Save(self.GenRepository.fileName,self.GenRepository.content)      
        
