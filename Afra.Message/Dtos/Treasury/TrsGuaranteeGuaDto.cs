using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsGuaranteeGuaDto
    {
          
 
		public Int32 TrsGuaranteeGuaId { get; set; }  
 
		public Int32 TGGGuaRef { get; set; }  
 
		public Nullable<Int32> TGGRcvDocId { get; set; }  
 
		public String TGGDescr { get; set; } 
    }
}


