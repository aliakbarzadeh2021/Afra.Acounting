using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleVchItm : BaseEntity
    {
          
 
		public Int32 SleVchItmId { get; set; }  
 
		public Nullable<Int32> SleVchHdrRef { get; set; }  
 
		public Nullable<Int32> SVISeq { get; set; }  
 
		public Int32 SVIPartRef { get; set; }  
 
		public Nullable<Int32> SVIUnitRef { get; set; }  
 
		public Double SVIMainQty { get; set; }  
 
		public Nullable<Double> SVIOthQty { get; set; }  
 
		public Double SVIAmount { get; set; }  
 
		public String SVIDescr { get; set; }  
 
		public Nullable<Int32> SVIRefID { get; set; }  
 
		public Nullable<Int32> SVIRefType { get; set; }  
 
		public Nullable<Double> SVICurVal { get; set; }  
 
		public Nullable<Int32> SVIPriceType { get; set; } 
    }
}


