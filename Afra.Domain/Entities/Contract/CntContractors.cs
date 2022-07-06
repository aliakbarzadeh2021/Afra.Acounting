using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntContractors : BaseEntity
    {
          
 
		public Int32 CntContrId { get; set; }  
 
		public Int32 CCCrsRef { get; set; }  
 
		public String CCActType { get; set; }  
 
		public String CCFileNo { get; set; }  
 
		public String CCPersiutNo { get; set; }  
 
		public String CCDirectorName { get; set; }  
 
		public String CCRespName { get; set; }  
 
		public String CCBankInf { get; set; }  
 
		public String CCAccountNo { get; set; }  
 
		public String CCECode { get; set; }  
 
		public DateTime CCDutyDate { get; set; }  
 
		public String CCDutyNum { get; set; }  
 
		public String CCSLRef { get; set; } 
    }
}


