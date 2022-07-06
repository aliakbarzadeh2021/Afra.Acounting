using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdConsumHdr : BaseEntity
    {
          
 
		public Int32 PrdConsumHdrId { get; set; }  
 
		public Int32 PCHNum { get; set; }  
 
		public Nullable<Int32> PCHLocalNum { get; set; }  
 
		public DateTime PCHDate { get; set; }  
 
		public String PCHDescr { get; set; }  
 
		public Int32 PCHProgRef { get; set; }  
 
		public String PCHDLRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> PCHState { get; set; }  
 
		public Nullable<Int32> PCHYear { get; set; } 
    }
}


