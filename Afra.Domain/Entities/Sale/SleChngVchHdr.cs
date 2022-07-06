using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleChngVchHdr : BaseEntity
    {
          
 
		public Int32 SleChngVchHdrID { get; set; }  
 
		public Int32 SCVHNum { get; set; }  
 
		public Nullable<Int32> SCVHLocalNum { get; set; }  
 
		public DateTime SCVHDate { get; set; }  
 
		public String SCVHDescr { get; set; }  
 
		public Int32 SCVHVchType { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> SCVHState { get; set; }  
 
		public Nullable<Int32> SCVAccPrdRef { get; set; } 
    }
}


