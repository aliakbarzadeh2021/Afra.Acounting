using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AccGLVchHdrDto
    {
          
 
		public Int32 AccGLVchHdrId { get; set; }  
 
		public Int32 AGVHNum { get; set; }  
 
		public DateTime AGVHDate { get; set; }  
 
		public Nullable<Int32> AGVHAccPrdRef { get; set; }  
 
		public Nullable<Int32> AccVchHdrRef { get; set; }  
 
		public Nullable<Int32> AGVHFNum { get; set; }  
 
		public Nullable<Int32> AGVHTNum { get; set; } 
    }
}


