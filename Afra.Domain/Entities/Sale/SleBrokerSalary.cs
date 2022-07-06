using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleBrokerSalary : BaseEntity
    {
          
 
		public Int32 SleBrokerSalaryId { get; set; }  
 
		public String SBSTitle { get; set; }  
 
		public DateTime SBSFDate { get; set; }  
 
		public DateTime SBSTDate { get; set; }  
 
		public Int32 SBSBaseMthd { get; set; }  
 
		public Int32 SBSOprType { get; set; } 
    }
}


