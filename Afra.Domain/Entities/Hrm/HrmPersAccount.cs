using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmPersAccount : BaseEntity
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


