using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayBdgBase : BaseEntity
    {
          
 
		public Int32 PayBdgBaseId { get; set; }  
 
		public Int32 PBBType { get; set; }  
 
		public Int32 PBBElmntRef { get; set; }  
 
		public Nullable<Int32> PBBPersRef { get; set; }  
 
		public Nullable<Int32> PBBEmpRef { get; set; }  
 
		public Nullable<Int32> PBBCostCntrRef { get; set; }  
 
		public Nullable<Int32> PBBWLocRef { get; set; }  
 
		public Nullable<Int32> PBBJobRef { get; set; }  
 
		public String PBBDLCode2 { get; set; }  
 
		public String PBBDLCode3 { get; set; }  
 
		public String PBBVal { get; set; } 
    }
}


