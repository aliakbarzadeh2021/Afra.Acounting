using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsGuaranteeSec : BaseEntity
    {
          
 
		public Int32 TrsGuaranteeSecId { get; set; }  
 
		public Int32 TGSGuaRef { get; set; }  
 
		public String TGSDLRef { get; set; }  
 
		public String TGSFullName { get; set; }  
 
		public String TGSNatCode { get; set; }  
 
		public String TGSPhone { get; set; }  
 
		public String TGSMobile { get; set; }  
 
		public String TGSDescr { get; set; } 
    }
}


