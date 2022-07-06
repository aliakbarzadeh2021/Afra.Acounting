using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleCstmrGroupsDto
    {
          
 
		public Int32 SleCstmrGroupId { get; set; }  
 
		public Nullable<Int32> SCGParent { get; set; }  
 
		public String SCGTitle { get; set; }  
 
		public String SCGDLRef { get; set; }  
 
		public Nullable<Int32> SCGMainRoot { get; set; } 
    }
}


