using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdOrdHdr : BaseEntity
    {
          
 
		public Int32 PrdOrdHdrId { get; set; }  
 
		public Int32 POHNum { get; set; }  
 
		public Nullable<Int32> POHLocalNum { get; set; }  
 
		public Int32 POHType { get; set; }  
 
		public DateTime POHDate { get; set; }  
 
		public String POHDLRef { get; set; }  
 
		public String POHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> POHState { get; set; }  
 
		public Nullable<Int32> POHYear { get; set; }  
 
		public Nullable<Int32> POHRefID { get; set; }  
 
		public Nullable<Int32> POHRefType { get; set; } 
    }
}


