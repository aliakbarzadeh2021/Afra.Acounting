using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccGLVchItm : BaseEntity
    {
          
 
		public Int32 AccGLVchItmId { get; set; }  
 
		public Nullable<Int32> AccGLVchHdrRef { get; set; }  
 
		public String AGVIGLRef { get; set; }  
 
		public Nullable<Double> AGVIDebit { get; set; }  
 
		public Nullable<Double> AGVICredit { get; set; } 
    }
}


