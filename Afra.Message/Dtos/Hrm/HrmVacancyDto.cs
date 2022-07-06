using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmVacancyDto
    {
          
 
		public Int32 HrmVacancyId { get; set; }  
 
		public String HVTitle { get; set; }  
 
		public Nullable<Int32> HVType { get; set; }  
 
		public Nullable<Int32> HVRole { get; set; } 
    }
}


