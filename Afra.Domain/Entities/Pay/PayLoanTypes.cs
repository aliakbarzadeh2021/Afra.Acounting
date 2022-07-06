using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayLoanTypes : BaseEntity
    {
          
 
		public Int32 PayLoanId { get; set; }  
 
		public String PLnTitle { get; set; }  
 
		public Nullable<Int32> PLnElmntRef { get; set; }  
 
		public Nullable<Double> PLnMaxAmnt { get; set; }  
 
		public String PLnDLRef { get; set; }  
 
		public Nullable<Int32> PLnActive { get; set; } 
    }
}


