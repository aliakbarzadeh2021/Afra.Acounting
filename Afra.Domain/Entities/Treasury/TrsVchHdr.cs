using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsVchHdr : BaseEntity
    {
          
 
		public Int32 TrsVchHdrId { get; set; }  
 
		public Int32 TVHVchKind { get; set; }  
 
		public String TVHType { get; set; }  
 
		public String TVHRole { get; set; }  
 
		public Int32 TVHNum { get; set; }  
 
		public Nullable<Int32> TVHLocalNum { get; set; }  
 
		public DateTime TVHDate { get; set; }  
 
		public String TVHDescr { get; set; }  
 
		public Nullable<Int32> TVHDocRef { get; set; }  
 
		public String TVHDocRefType { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> TVHState { get; set; }  
 
		public Nullable<Int32> TAccPrdRef { get; set; }  
 
		public Nullable<Int32> TVHRefID { get; set; }  
 
		public Nullable<Int32> TVHRefType { get; set; }  
 
		public Nullable<Int32> TVHCreator { get; set; }  
 
		public Nullable<Int32> TVHSit { get; set; } 
    }
}


