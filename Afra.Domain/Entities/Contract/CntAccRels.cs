using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntAccRels : BaseEntity
    {
          
 
		public Int32 CntAccRelId { get; set; }  
 
		public Int32 CntAccVchTypeRef { get; set; }  
 
		public Int32 CARFieldRef { get; set; }  
 
		public Int32 CARBalanceType { get; set; }  
 
		public String CARSLRef { get; set; }  
 
		public String CARDLType { get; set; }  
 
		public String CARDLCode { get; set; }  
 
		public String CARDLFiveType { get; set; }  
 
		public String CARDLFiveCode { get; set; }  
 
		public String CARDLSixType { get; set; }  
 
		public String CARDLSixCode { get; set; }  
 
		public String CARDescr { get; set; }  
 
		public Nullable<Int32> CARPriovity { get; set; }  
 
		public Nullable<Int32> CARGroup { get; set; }  
 
		public Nullable<Int32> CARCurType { get; set; }  
 
		public Nullable<Int32> CARSLType { get; set; }  
 
		public Nullable<Int32> CARIsMain { get; set; } 
    }
}


