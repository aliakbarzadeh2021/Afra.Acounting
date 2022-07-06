using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayLoanTypesDto
    {
          
 
		public Int32 PayLoanId { get; set; }  
 
		public String PLnTitle { get; set; }  
 
		public Nullable<Int32> PLnElmntRef { get; set; }  
 
		public Nullable<Double> PLnMaxAmnt { get; set; }  
 
		public String PLnDLRef { get; set; }  
 
		public Nullable<Int32> PLnActive { get; set; } 
    }
}


