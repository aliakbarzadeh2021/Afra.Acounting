using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsPayChqItm : BaseEntity
    {
          
 
		public Int32 PayChqOprItmId { get; set; }  
 
		public Nullable<Int32> PCOHdrRef { get; set; }  
 
		public Int32 PCOIAccOprRef { get; set; }  
 
		public Nullable<Int32> PCOIBankAccRef { get; set; }  
 
		public Nullable<Int32> PCOICashRef { get; set; }  
 
		public Int32 PCOIChqRef { get; set; }  
 
		public Nullable<Int32> PCOISeq { get; set; }  
 
		public String PCOIDescr { get; set; }  
 
		public DateTime PCOIDate { get; set; }  
 
		public String PCOIDLRef { get; set; } 
    }
}


