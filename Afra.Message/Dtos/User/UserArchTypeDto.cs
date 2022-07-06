using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class UserArchTypeDto
    {
          
 
		public Int32 UserArchTypeId { get; set; }  
 
		public Int32 UATUsrRef { get; set; }  
 
		public String UATTitle { get; set; }  
 
		public Nullable<Int32> UATParent { get; set; } 
    }
}


