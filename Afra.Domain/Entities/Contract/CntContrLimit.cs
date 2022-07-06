using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntContrLimit : BaseEntity
    {
          
 
		public Int32 CntContrLimitId { get; set; }  
 
		public Int32 CCLContrRef { get; set; }  
 
		public Int32 CCLState { get; set; }  
 
		public DateTime CCLDate { get; set; }  
 
		public String CCLDescr { get; set; } 
    }
}


