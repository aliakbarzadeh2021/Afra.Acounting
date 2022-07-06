using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class GnrUserFormDesignDto
    {
          
 
		public Int32 GUFDFormRef { get; set; }  
 
		public Int32 GUFDFieldRef { get; set; }  
 
		public Int32 GUFDPropRef { get; set; }  
 
		public Nullable<Int32> GUFDValue { get; set; }  
 
		public String GUFDFieldParent { get; set; } 
    }
}


