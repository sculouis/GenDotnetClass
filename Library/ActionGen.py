
class ActionGen:
    def __init__(self,Xls,Gen):
        """設定template的目錄"""
        self.Xls=Xls
        self.Gen=Gen

    def run(self):
        """執行產生Code First Class"""
        for sheetName in self.Xls.getSheetNames():
            rows = self.Xls.GetRows(sheetName)
            self.Gen.GenCSFile(sheetName,rows)
 