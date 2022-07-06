using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdSendHdr : BaseEntity
    {
          
 
		public Int32 PrdSendHdrId { get; set; }  
 
		public Int32 PSHNum { get; set; }  
 
		public Nullable<Int32> PSHLocalNum { get; set; }  
 
		public Nullable<Int32> PSHKind { get; set; }  
 
		public Int32 PSHType { get; set; }  
 
		public DateTime PSHDate { get; set; }  
 
		public Int32 PSHSendRef { get; set; }  
 
		public Int32 PSHRespRef { get; set; }  
 
		public String PSHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> PSHState { get; set; }  
 
		public Nullable<Int32> PSHYear { get; set; } 
    }
}


