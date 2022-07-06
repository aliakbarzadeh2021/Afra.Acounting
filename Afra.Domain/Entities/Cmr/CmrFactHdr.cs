using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrFactHdr : BaseEntity
    {
          
 
		public Int32 CmrFactHdrId { get; set; }  
 
		public Int32 CFHNum { get; set; }  
 
		public Nullable<Int32> CFHLocalNum { get; set; }  
 
		public Nullable<Int32> CFHPOrdRef { get; set; }  
 
		public DateTime CFHDate { get; set; }  
 
		public String CFHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CFHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; }  
 
		public Nullable<Int32> CFHSellerRef { get; set; }  
 
		public Nullable<Int32> CFHCurRef { get; set; }  
 
		public Nullable<Double> CFHCurRate { get; set; }  
 
		public Nullable<Int32> CFHTransType { get; set; } 
    }
}


