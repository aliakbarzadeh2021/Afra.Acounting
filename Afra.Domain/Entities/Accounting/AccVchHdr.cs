using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccVchHdr : BaseEntity
    {
          
 
		public Int32 AccVchHdrId { get; set; }  
 
		public Int32 AVHNum { get; set; }  
 
		public Int32 AVHTempNum { get; set; }  
 
		public Nullable<Int32> AVHLocalNum { get; set; }  
 
		public DateTime AVHDate { get; set; }  
 
		public String AVHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> VchState { get; set; }  
 
		public Nullable<Int32> AccPrdRef { get; set; }  
 
		public String AccSysRef { get; set; }  
 
		public Nullable<Int32> VchCtgry { get; set; }  
 
		public Nullable<Int32> AVHGrpRef { get; set; } 
    }
}


