using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class UsersDto
    {
          
 
		public Int32 UserId { get; set; }  
 
		public String UserName { get; set; }  
 
		public String UserPass { get; set; }  
 
		public Nullable<Int32> UserGroupRef { get; set; }  
 
		public Byte[] UserSign { get; set; }  
 
		public Nullable<Int32> UserState { get; set; } 
    }
}


