using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmPersRltd : BaseEntity
    {
          
 
		public Int32 PersRltdId { get; set; }  
 
		public Nullable<Int32> PersRltdPersRef { get; set; }  
 
		public DateTime PersRltdBDate { get; set; }  
 
		public String PersRltdFullName { get; set; }  
 
		public String PersRltdType { get; set; }  
 
		public Nullable<Int32> PersRltdHaveInsu { get; set; } 
    }
}


