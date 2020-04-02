 
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace DataAccess
{
    public class FormMaster 
    {
        /// <summary> 
        /// 表單主檔編號 
        /// </summary>         
        public int Id { get; set; }

        /// <summary> 
        /// 表單種類 
        /// </summary>         
        public int FormKind { get; set; }

        /// <summary> 
        /// 處理人員工代號 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string FillInEmpNum { get; set; }

        /// <summary> 
        /// 處理人姓名 
        /// </summary>         
        [Column(TypeName="nvarchar(20)")] 
        public string FillInName { get; set; }

        /// <summary> 
        /// 處理人單位代號 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string FillInDepId { get; set; }

        /// <summary> 
        /// 申請人員工代號 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string ApplicantEmpNum { get; set; }

        /// <summary> 
        /// 申請人姓名 
        /// </summary>         
        [Column(TypeName="nvarchar(20)")] 
        public string ApplicantName { get; set; }

        /// <summary> 
        /// 申請人單位代號 
        /// </summary>         
        [Column(TypeName="varchar(10)")] 
        public string ApplicantDepId { get; set; }

        /// <summary> 
        /// JBPM uid 
        /// </summary>         
        [Column(TypeName="varchar(30)")] 
        public string JbpmUid { get; set; }

        /// <summary> 
        /// 表單狀態 
        /// </summary>         
        public int FormStatus { get; set; }

        /// <summary> 
        /// 表單建立時間 
        /// </summary>         
        public DateTime CreateTime { get; set; }

        /// <summary> 
        /// 起單時間 
        /// </summary>         
        public DateTime StartProcessTime { get; set; }

        public List<EXPMaster> EXPMaster {get;set;}    
        public List<ENPMaster> ENPMaster {get;set;}    
    }


}

