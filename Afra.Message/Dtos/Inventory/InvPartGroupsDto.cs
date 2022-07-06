using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class InvPartGroupsDto
    {
          
 
		public Int32 InvPartGroupsId { get; set; }  
 
		public Nullable<Int32> IPGParent { get; set; }  
 
		public String IPGCode { get; set; }  
 
		public String IPGTitle { get; set; }  
 
		public String IPGDLRef { get; set; }  
 
		public Nullable<Int32> IPGMainRoot { get; set; } 
    }
}


