using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvVchItm : BaseEntity
    {
          
 
		public Int32 InvVchItmId { get; set; }  
 
		public Nullable<Int32> InvVchHdrRef { get; set; }  
 
		public Nullable<Int32> IVISeq { get; set; }  
 
		public Int32 IVIPartRef { get; set; }  
 
		public Nullable<Int32> IVIUnitRef { get; set; }  
 
		public Double IVIMainQty { get; set; }  
 
		public Nullable<Double> IVIOthQty { get; set; }  
 
		public String IVIDescr { get; set; }  
 
		public String IVIDLRef { get; set; }  
 
		public String IVISLRef { get; set; }  
 
		public Nullable<Int32> IVIRefID { get; set; }  
 
		public Nullable<Int32> IVIRefType { get; set; }  
 
		public Nullable<Int32> IVIFormulRef { get; set; }  
 
		public String IVIDL5Ref { get; set; }  
 
		public String IVIDL6Ref { get; set; } 
    }
}


