using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsRqstItm : BaseEntity
    {
          
 
		public Int32 TrsRqstItmId { get; set; }  
 
		public Nullable<Int32> TrsRqstHdrRef { get; set; }  
 
		public Nullable<Int32> TRICashFactRef { get; set; }  
 
		public Nullable<Int32> TRIBankAccRef { get; set; }  
 
		public Nullable<Int32> TRICashRef { get; set; }  
 
		public String TRIDLRef { get; set; }  
 
		public Nullable<Int32> TRISeq { get; set; }  
 
		public String TRIDescr { get; set; }  
 
		public DateTime TRIDate { get; set; }  
 
		public Double TRIQty { get; set; }  
 
		public String TRIDLFive { get; set; }  
 
		public String TRIDLSix { get; set; } 
    }
}


