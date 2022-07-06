using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleGuaDocs : BaseEntity
    {
          
 
		public Int32 SleGuaDocId { get; set; }  
 
		public String SGDNum { get; set; }  
 
		public Int32 SGDFactRef { get; set; }  
 
		public DateTime SGDStDate { get; set; }  
 
		public DateTime SGDEnDate { get; set; }  
 
		public String SGDDescr { get; set; } 
    }
}


