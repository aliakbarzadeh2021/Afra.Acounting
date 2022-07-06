using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmGrpStatus : BaseEntity
    {
          
 
		public Int32 HrmGrpStatId { get; set; }  
 
		public Int32 HGSType { get; set; }  
 
		public Int32 HGSNum { get; set; }  
 
		public DateTime HGSIssueDate { get; set; }  
 
		public DateTime HGSEffectDate { get; set; }  
 
		public String HGSDescr { get; set; }  
 
		public Int32 HGSEmpType { get; set; }  
 
		public Nullable<Int32> HGSCostCenter { get; set; }  
 
		public Nullable<Int32> HGSWorkLoc { get; set; }  
 
		public Nullable<Int32> HGSDeptRef { get; set; }  
 
		public Nullable<Int32> HGSJobRef { get; set; }  
 
		public String HGSIYrMonth { get; set; }  
 
		public String HGSEYrMonth { get; set; }  
 
		public DateTime HGSEmpDate { get; set; }  
 
		public String HGSDLRef2 { get; set; }  
 
		public String HGSDLRef3 { get; set; }  
 
		public Nullable<Int32> HGSFmtRef { get; set; }  
 
		public DateTime HGSContStart { get; set; }  
 
		public DateTime HGSContEnd { get; set; }  
 
		public String HGSContNo { get; set; }  
 
		public String HGSContDescr { get; set; }  
 
		public Nullable<Int32> HGSTaxType { get; set; }  
 
		public String HGSDLRef { get; set; } 
    }
}


