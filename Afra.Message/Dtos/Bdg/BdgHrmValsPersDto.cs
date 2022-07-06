using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgHrmValsPersDto
    {
          
 
		public Int32 BdgHrmValsPersId { get; set; }  
 
		public Int32 BHVPParentRef { get; set; }  
 
		public String BHVPFullName { get; set; }  
 
		public Double BHVPAmount { get; set; }  
 
		public Nullable<Int32> BHVPCurRef { get; set; } 
    }
}


