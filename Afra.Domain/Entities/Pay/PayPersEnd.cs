using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayPersEnd : BaseEntity
    {
          
 
		public Int32 PayPersEndId { get; set; }  
 
		public Int32 PPEYearNum { get; set; }  
 
		public Int32 PPEMonthNum { get; set; }  
 
		public Int32 PPEPersRef { get; set; }  
 
		public Nullable<Int32> PPEElmntRef { get; set; }  
 
		public String PPETitle { get; set; }  
 
		public String PPEBase { get; set; }  
 
		public Double PPEVal { get; set; } 
    }
}


