 
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace DataAccess
{
    public class ENPDetail 
    {
        /// <summary> 
        /// 項次 
        /// </summary>         
        public int Id { get; set; }

        /// <summary> 
        /// 表單主檔系統編號 
        /// </summary>         
        public int ENPMasterId { get; set; }
        public ENPMaster ENPMaster {get;set;}    

        /// <summary> 
        /// 請款大類 
        /// </summary>         
        [Column(TypeName="varchar(100)")] 
        public string PaymentCategory { get; set; }

        /// <summary> 
        /// 請款中類 
        /// </summary>         
        [Column(TypeName="varchar(100)")] 
        public string PaymentMidCategory { get; set; }

        /// <summary> 
        /// 費用屬性 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string ExpenseAttribute { get; set; }

        /// <summary> 
        /// 會計項子目 
        /// </summary>         
        [Column(TypeName="varchar(100)")] 
        public string AccountingItem { get; set; }

        /// <summary> 
        /// 需檢附憑證 
        /// </summary>         
        [Column(TypeName="varchar(1)")] 
        public string NeedCertificate { get; set; }

        /// <summary> 
        /// 攤銷貼標註記 
        /// </summary>         
        public bool AmortizationFlag { get; set; }

        /// <summary> 
        /// 金額（原幣） 
        /// </summary>         
        [Column(TypeName = "decimal(15,8)")] 
        public decimal OriginalAmount { get; set; }

        /// <summary> 
        /// 稅額（原幣） 
        /// </summary>         
        [Column(TypeName = "decimal(15,8)")] 
        public decimal OriginalTax { get; set; }

        /// <summary> 
        /// 銷售額（原幣） 
        /// </summary>         
        public Int64 OriginalSaleAmount { get; set; }

        /// <summary> 
        /// 金額（臺幣） 
        /// </summary>         
        public Int64 TWDAmount { get; set; }

        /// <summary> 
        /// 稅額（臺幣） 
        /// </summary>         
        public Int64 TWDTax { get; set; }

        /// <summary> 
        /// 銷售金額（臺幣） 
        /// </summary>         
        public Int64 TWDSaleAmount { get; set; }

        /// <summary> 
        /// 攤銷(起) 
        /// </summary>         
        public DateTime AmortizationStartDate { get; set; }

        /// <summary> 
        /// 攤銷(迄) 
        /// </summary>         
        public DateTime AmortizationEndDate { get; set; }

        /// <summary> 
        /// 所扣 
        /// </summary>         
        public bool IsIncomeDeduction { get; set; }

        /// <summary> 
        /// 是否須檢附憑證 
        /// </summary>         
        public bool IsCheckCertificate { get; set; }

        /// <summary> 
        /// 專案類別 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string ProjectCategory { get; set; }

        /// <summary> 
        /// 專案 
        /// </summary>         
        [Column(TypeName="varchar(20)")] 
        public string Project { get; set; }

        /// <summary> 
        /// 專案項目 
        /// </summary>         
        [Column(TypeName="varchar(20)")] 
        public string ProjectItem { get; set; }

        /// <summary> 
        /// 傳票摘要 
        /// </summary>         
        [Column(TypeName="nvarchar(100)")] 
        public string VoucherMemo { get; set; }

        /// <summary> 
        /// 刪除註記 
        /// </summary>         
        public bool IsDelete { get; set; }

        /// <summary> 
        /// 表單建立時間 
        /// </summary>         
        public DateTime CreateTime { get; set; }

        /// <summary> 
        /// 表單刪除時間 
        /// </summary>         
        public DateTime DeleteTime { get; set; }

        /// <summary> 
        /// 表單修改時間 
        /// </summary>         
        public DateTime ModifyTime { get; set; }

        /// <summary> 
        /// 建立人員工代號 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string CreateBy { get; set; }

        /// <summary> 
        /// 刪除人員工代號 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string DeleteBy { get; set; }

        /// <summary> 
        /// 修改人員工代號 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string ModifyBy { get; set; }

    }


}

