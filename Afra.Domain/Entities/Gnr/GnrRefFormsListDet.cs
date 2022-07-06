using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrRefFormsListDet : BaseEntity
    {
          
 
		public Int32 RFLDHdrRef { get; set; }  
 
		public String RFLDFieldName { get; set; }  
 
		public String RFLDTitle { get; set; } 
    }
}


