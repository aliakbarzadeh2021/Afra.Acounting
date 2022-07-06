using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmStatElmntMthd : BaseEntity
    {
          
 
		public Int32 HrmStatElmntMthdId { get; set; }  
 
		public Int32 HSEMElmntRef { get; set; }  
 
		public Int32 HSEMEmpRef { get; set; }  
 
		public Int32 HSEMIYear { get; set; }  
 
		public Int32 HSEMIMonth { get; set; }  
 
		public Int32 HSEMEYear { get; set; }  
 
		public Int32 HSEMEMonth { get; set; }  
 
		public Nullable<Int32> HSEMIYearMonth { get; set; }  
 
		public Nullable<Int32> HSEMEYearMonth { get; set; }  
 
		public Nullable<Int32> HSEMAct { get; set; }  
 
		public String HSEMFormula { get; set; } 
    }
}


