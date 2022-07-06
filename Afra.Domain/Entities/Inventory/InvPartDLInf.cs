using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvPartDLInf : BaseEntity
    {
          
 
		public Int32 InvPartDLInfId { get; set; }  
 
		public Nullable<Int32> IPDIPartRef { get; set; }  
 
		public DateTime IPDIDate { get; set; }  
 
		public String IPDISupplier { get; set; }  
 
		public Nullable<Int32> IPDISupIsLimit { get; set; }  
 
		public String IPDIConsumer { get; set; }  
 
		public Nullable<Int32> IPDIConsIsLimit { get; set; }  
 
		public Nullable<Double> IPDIBuyPrice { get; set; } 
    }
}


