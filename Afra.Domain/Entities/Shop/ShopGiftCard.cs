using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class ShopGiftCard : BaseEntity
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


