 
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace DataAccess
{
    public class EXPMaster 
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
        /// 請款類別 
        /// </summary>         
        [Column(TypeName="varchar(15)")] 
        public string ExpenseKind { get; set; }

        /// <summary> 
        /// 供應商/請款編號 
        /// </summary>         
        [Column(TypeName="varchar(100)")] 
        public string VendorNum { get; set; }

        /// <summary> 
        /// 供應商名稱 
        /// </summary>         
        [Column(TypeName="nvarchar(100)")] 
        public string VendorName { get; set; }

        /// <summary> 
        /// 付款狀態 
        /// </summary>         
        [Column(TypeName="varchar(1)")] 
        public string PaymentStatus { get; set; }

        /// <summary> 
        /// 急件 
        /// </summary>         
        public bool Emergency { get; set; }

        /// <summary> 
        /// 單獨付款 
        /// </summary>         
        public bool PayAlone { get; set; }

        /// <summary> 
        /// 預計付款日期 
        /// </summary>         
        public DateTime EstimatePayDate { get; set; }

        /// <summary> 
        /// 憑證開立對象 
        /// </summary>         
        [Column(TypeName="varchar(60)")] 
        public string VoucherBeau { get; set; }

        /// <summary> 
        /// 帳務行 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string Books { get; set; }

        /// <summary> 
        /// 帳務行名稱 
        /// </summary>         
        [Column(TypeName="nvarchar(50)")] 
        public string BooksName { get; set; }

        /// <summary> 
        /// 請款主旨 
        /// </summary>         
        [Column(TypeName="varchar(2000)")] 
        public string HeaderDesc { get; set; }

        /// <summary> 
        /// 請款說明 
        /// </summary>         
        [Column(TypeName="varchar(100)")] 
        public string ExpenseDesc { get; set; }

        /// <summary> 
        /// 商業發票批次序號 
        /// </summary>         
        [Column(TypeName="varchar(50)")] 
        public string VoucherNumber { get; set; }

        /// <summary> 
        /// 傳票號碼 
        /// </summary>         
        [Column(TypeName="varchar(50)")] 
        public string ApBatchName { get; set; }

        /// <summary> 
        /// 總帳日期 
        /// </summary>         
        public DateTime GlDate { get; set; }

        /// <summary> 
        /// 供應商地址 
        /// </summary>         
        [Column(TypeName="nvarchar(500)")] 
        public string VendorAddress { get; set; }

        /// <summary> 
        /// 供應商類別 
        /// </summary>         
        [Column(TypeName="varchar(20)")] 
        public string VendorKind { get; set; }

        /// <summary> 
        /// 所得人統一編(證號) 
        /// </summary>         
        [Column(TypeName="varchar(30)")] 
        public string IDNo { get; set; }

        /// <summary> 
        /// 戶籍地址郵遞區號 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string PermanentPostNum { get; set; }

        /// <summary> 
        /// 戶籍地址 
        /// </summary>         
        [Column(TypeName="nvarchar(500)")] 
        public string PermanentAddress { get; set; }

        /// <summary> 
        /// 聯絡地址郵遞區號 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string ContactPostNum { get; set; }

        /// <summary> 
        /// 聯絡地址 
        /// </summary>         
        [Column(TypeName="nvarchar(500)")] 
        public string ContactAddress { get; set; }

        /// <summary> 
        /// 證號別 
        /// </summary>         
        [Column(TypeName="varchar(50)")] 
        public string CertificateKind { get; set; }

        /// <summary> 
        /// 國別 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string CountryCode { get; set; }

    }


}

