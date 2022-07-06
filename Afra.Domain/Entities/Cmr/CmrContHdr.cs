using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrContHdr : BaseEntity
    {
          
 
		public Int32 CmrContHdrId { get; set; }  
 
		public Int32 CCHNum { get; set; }  
 
		public DateTime CCHDate { get; set; }  
 
		public Int32 CCHSellerRef { get; set; }  
 
		public String CCHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CCHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; }  
 
		public Nullable<Int32> CCHRefID { get; set; }  
 
		public Nullable<Int32> CCHRefType { get; set; } 
    }
}

