using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleSrvGroupsDto
    {
          
 
		public Int32 SleSrvGroupsId { get; set; }  
 
		public Nullable<Int32> SSGParent { get; set; }  
 
		public String SSGCode { get; set; }  
 
		public String SSGTitle { get; set; }  
 
		public String SSGDLRef { get; set; }  
 
		public Nullable<Int32> SSGMainRoot { get; set; } 
    }
}


