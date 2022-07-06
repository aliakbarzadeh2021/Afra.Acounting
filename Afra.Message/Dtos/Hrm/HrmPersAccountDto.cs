using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmPersAccountDto
    {
          
 
		public Int32 HrmPersAcntId { get; set; }  
 
		public Int32 HPAPersRef { get; set; }  
 
		public Int32 HPABankRef { get; set; }  
 
		public DateTime HPADate { get; set; }  
 
		public Nullable<Int32> HPAElmntRef { get; set; }  
 
		public String HPANumber { get; set; }  
 
		public Nullable<Int32> HPASit { get; set; } 
    }
}


