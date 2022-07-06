using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PrdPOrdHdrDto
    {
          
 
		public Int32 PrdPOrdHdrId { get; set; }  
 
		public Int32 PPOHNum { get; set; }  
 
		public DateTime PPOHDate { get; set; }  
 
		public String PPOHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> PPOHState { get; set; }  
 
		public Nullable<Int32> PPOHYear { get; set; } 
    }
}


