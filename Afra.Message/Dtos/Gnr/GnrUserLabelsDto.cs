using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class GnrUserLabelsDto
    {
          
 
		public Int32 GnrUserLabelId { get; set; }  
 
		public Int32 GULUserRef { get; set; }  
 
		public String GULTitle { get; set; }  
 
		public Nullable<Int32> GULParent { get; set; } 
    }
}


