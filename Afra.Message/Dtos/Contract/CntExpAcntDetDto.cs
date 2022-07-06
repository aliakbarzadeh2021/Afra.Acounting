using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntExpAcntDetDto
    {
          
 
		public Int32 CntExpAcntDetId { get; set; }  
 
		public Int32 CEADItemRef { get; set; }  
 
		public Int32 CEADExpAcntRef { get; set; }  
 
		public Double CEADQty { get; set; }  
 
		public Nullable<Int32> CEADDur { get; set; } 
    }
}


