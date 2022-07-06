using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmVacancy : BaseEntity
    {
          
 
		public Int32 HrmVacancyId { get; set; }  
 
		public String HVTitle { get; set; }  
 
		public Nullable<Int32> HVType { get; set; }  
 
		public Nullable<Int32> HVRole { get; set; } 
    }
}


