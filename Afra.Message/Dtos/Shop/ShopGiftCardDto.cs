using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class ShopGiftCardDto
    {
          
 
		public Int32 ShopGiftCardId { get; set; }  
 
		public String SGCNumber { get; set; }  
 
		public Double SGCAmount { get; set; }  
 
		public DateTime SGCExpDate { get; set; }  
 
		public String SGCDescr { get; set; }  
 
		public Nullable<Int32> SGCGrpRef { get; set; }  
 
		public Nullable<Int32> SGCState { get; set; } 
    }
}


