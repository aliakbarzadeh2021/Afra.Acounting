using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntCMthdFlds : BaseEntity
    {
          
 
		public Int32 CntCMthdFldId { get; set; }  
 
		public Int32 CCMFldRef { get; set; }  
 
		public String CCMFDescr { get; set; }  
 
		public String CCMFormula { get; set; }  
 
		public String CCMFormulDescr { get; set; } 
    }
}


