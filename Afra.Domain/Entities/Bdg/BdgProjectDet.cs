using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgProjectDet : BaseEntity
    {
          
 
		public Int32 BdgProjectDetId { get; set; }  
 
		public Int32 BPDHdrRef { get; set; }  
 
		public String BPDDescr { get; set; }  
 
		public Nullable<Double> BPDQty { get; set; }  
 
		public Nullable<Int32> BPDUnit { get; set; }  
 
		public Nullable<Int32> BPDCurRef { get; set; }  
 
		public Nullable<Double> BPDRate { get; set; }  
 
		public String BPDSLRef { get; set; } 
    }
}


