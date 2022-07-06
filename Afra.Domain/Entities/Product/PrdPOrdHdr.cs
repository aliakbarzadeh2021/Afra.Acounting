using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdPOrdHdr : BaseEntity
    {
          
 
		public Int32 PrdPOrdHdrId { get; set; }  
 
		public Int32 PPOHNum { get; set; }  
 
		public DateTime PPOHDate { get; set; }  
 
		public String PPOHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> PPOHState { get; set; }  
 
		public Nullable<Int32> PPOHYear { get; set; } 
    }
}


