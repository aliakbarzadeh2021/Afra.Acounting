using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFacilitiesSec : BaseEntity
    {
          
 
		public Int32 TrsFacilitiesSecId { get; set; }  
 
		public Int32 TFSFacRef { get; set; }  
 
		public String TFSDLRef { get; set; }  
 
		public String TFSFullName { get; set; }  
 
		public String TFSNatCode { get; set; }  
 
		public String TFSPhone { get; set; }  
 
		public String TFSMobile { get; set; }  
 
		public String TFSDescr { get; set; } 
    }
}


