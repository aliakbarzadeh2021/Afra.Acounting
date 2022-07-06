using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvVchTrans : BaseEntity
    {
          
 
		public Int32 InvVchTransId { get; set; }  
 
		public Nullable<Int32> InvVchItmRef { get; set; }  
 
		public String IVTNum { get; set; }  
 
		public DateTime IVTDater { get; set; }  
 
		public Nullable<Double> IVTQty { get; set; }  
 
		public String IVTDriver { get; set; }  
 
		public String IVTCarNo { get; set; }  
 
		public String IVTDescr { get; set; } 
    }
}


