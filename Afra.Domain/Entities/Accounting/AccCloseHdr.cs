using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccCloseHdr : BaseEntity
    {
          
 
		public Int32 AccCloseHdrId { get; set; }  
 
		public String ACHDescr { get; set; }  
 
		public String ACHType { get; set; }  
 
		public String ACHSLRef { get; set; }  
 
		public String ACHDLRef { get; set; }  
 
		public String ACHDLFive { get; set; }  
 
		public String ACHDLSix { get; set; }  
 
		public Int32 ACHAccPrdRef { get; set; }  
 
		public Nullable<Int32> AccVchHdrRef { get; set; } 
    }
}


