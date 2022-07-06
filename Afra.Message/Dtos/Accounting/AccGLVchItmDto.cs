using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AccGLVchItmDto
    {
          
 
		public Int32 AccGLVchItmId { get; set; }  
 
		public Nullable<Int32> AccGLVchHdrRef { get; set; }  
 
		public String AGVIGLRef { get; set; }  
 
		public Nullable<Double> AGVIDebit { get; set; }  
 
		public Nullable<Double> AGVICredit { get; set; } 
    }
}


