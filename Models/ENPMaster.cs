using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess
{
    public class ENPMaster 
    {
        /// <summary> 
        /// 系統編號 
        /// </summary>         
        public int Id { get; set; }

        /// <summary> 
        /// 表單主檔系統編號 
        /// </summary>         
        public int FormMasterId { get; set; }
        public FormMaster FormMaster {get;set;}    

        /// <summary> 
        /// 非請購單號 
        /// </summary>         
        [Column(TypeName="varchar(20)")] 
        public string ENPNum { get; set; }

        /// <summary> 
        /// 購買國外勞務 
        /// </summary>         
        public bool ForeignLabor { get; set; }

        /// <summary> 
        /// 所扣 
        /// </summary>         
        public bool Deduction { get; set; }

        /// <summary> 
        /// 待補憑證 
        /// </summary>         
        public bool Certificate { get; set; }

        /// <summary> 
        /// 預計補憑日期 
        /// </summary>         
        public DateTime ExpectedDate { get; set; }

        /// <summary> 
        /// 幣別 
        /// </summary>         
        [Column(TypeName="varchar(3)")] 
        public string Currency { get; set; }

        /// <summary> 
        /// 幣別精確度 
        /// </summary>         
        public int CurrencyPrecise { get; set; }

        /// <summary> 
        /// 匯率 
        /// </summary>         
        [Column(TypeName = "decimal(11,8)")] 
        public decimal Rate { get; set; }

        /// <summary> 
        /// 合約號碼 
        /// </summary>         
        [Column(TypeName="varchar(20)")] 
        public string ContractNum { get; set; }

        /// <summary> 
        /// 憑證類別 
        /// </summary>         
        [Column(TypeName="varchar(1)")] 
        public string CertificateKind { get; set; }

        /// <summary> 
        /// 憑證號碼 
        /// </summary>         
        [Column(TypeName="varchar(15)")] 
        public string CertificateNum { get; set; }

        /// <summary> 
        /// 憑證日期 
        /// </summary>         
        public DateTime EstimateVoucherDate { get; set; }

        /// <summary> 
        /// 折讓發票 
        /// </summary>         
        [Column(TypeName="varchar(50)")] 
        public string DiscountInvoice { get; set; }

        /// <summary> 
        /// 折讓發票日期 
        /// </summary>         
        public DateTime DiscountInvoiceDate { get; set; }

        /// <summary> 
        /// 折讓收款 
        /// </summary>         
        public bool DiscountReceive { get; set; }

        /// <summary> 
        /// 發票逾期說明 
        /// </summary>         
        [Column(TypeName="nvarchar(2000)")] 
        public string InvoiceOverdue { get; set; }

        /// <summary> 
        /// 跨年度傳票編號 
        /// </summary>         
        [Column(TypeName="varchar(200)")] 
        public string YearVoucher { get; set; }

        /// <summary> 
        /// 議價編碼 
        /// </summary>         
        [Column(TypeName="varchar(50)")] 
        public string BargainingCode { get; set; }

        /// <summary> 
        /// 憑證總額 (原幣) 
        /// </summary>         
        [Column(TypeName = "decimal(15,6)")] 
        public decimal CertificateAmount { get; set; }

        /// <summary> 
        /// 憑證稅額（原幣） 
        /// </summary>         
        [Column(TypeName = "decimal(15,6)")] 
        public decimal OriginalAmount { get; set; }

        /// <summary> 
        /// 金額總計（臺幣） 
        /// </summary>         
        public Int64 TWDAmount { get; set; }

        /// <summary> 
        /// 稅額總計（臺幣） 
        /// </summary>         
        public Int64 TWDPayAmount { get; set; }

        /// <summary> 
        /// 付款金額(臺幣)* 
        /// </summary>         
        public Int64 PaymentAmount { get; set; }

        /// <summary> 
        /// 付款預扣金額(保證金) 
        /// </summary>         
        [Column(TypeName = "decimal(15,6)")] 
        public decimal MARGINAMT { get; set; }

        /// <summary> 
        /// 預扣會計項子目(保證金) 
        /// </summary>         
        [Column(TypeName = "decimal(15,6)")] 
        public decimal WithHoldingAccountingAmount { get; set; }

        /// <summary> 
        /// 匯出申報性質(外幣) 
        /// </summary>         
        [Column(TypeName="nvarchar(100)")] 
        public string ExportApplyAttribute { get; set; }

        public List<ENPDetail> ENPDetail {get;set;}    
    }


}

