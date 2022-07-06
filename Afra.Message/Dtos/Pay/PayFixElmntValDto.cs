using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayFixElmntValDto
    {
          
 
		public Int32 PayFixElmntValId { get; set; }  
 
		public Int32 PFEVElmntRef { get; set; }  
 
		public Int32 PFEVYear { get; set; }  
 
		public Int32 PFEVMonth { get; set; }  
 
		public Double PFEVAmount { get; set; }  
 
		public Nullable<Int32> PFEVYearMonth { get; set; } 
    }
}


