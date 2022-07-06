using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgCurExchangeDto
    {
          
 
		public Int32 BdgCurExchangeId { get; set; }  
 
		public DateTime BCEDate { get; set; }  
 
		public Int32 BCECurRef { get; set; }  
 
		public Double BCERate { get; set; }  
 
		public Int32 BCEPeriodRef { get; set; } 
    }
}


