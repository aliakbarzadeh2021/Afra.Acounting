using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class UserSignRightDto
    {
          
 
		public Int32 UserSignRightId { get; set; }  
 
		public Nullable<Int32> USRUserRef { get; set; }  
 
		public Nullable<Int32> USRToUser { get; set; }  
 
		public Nullable<Int32> USRAccess { get; set; } 
    }
}


