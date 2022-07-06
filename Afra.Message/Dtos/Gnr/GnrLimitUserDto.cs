using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class GnrLimitUserDto
    {
          
 
		public Int32 GnrLimitUserId { get; set; }  
 
		public Int32 GLUGroupRef { get; set; }  
 
		public Int32 GLUUserRef { get; set; }  
 
		public Int32 GLUObjRef { get; set; }  
 
		public Nullable<Int32> GLUAccess { get; set; } 
    }
}


