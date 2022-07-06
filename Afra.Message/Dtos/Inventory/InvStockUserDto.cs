using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class InvStockUserDto
    {
          
 
		public Int32 InvStockUserId { get; set; }  
 
		public Int32 ISUStockRef { get; set; }  
 
		public Int32 ISUUserRef { get; set; }  
 
		public Nullable<Int32> ISURight { get; set; } 
    }
}


