using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstCostCntrElmntRole : BaseEntity
    {
          
 
		public Int32 CCnERCostCntRef { get; set; }  
 
		public Int32 CCnERElmntRef { get; set; }  
 
		public Int32 CCnERRoleRef { get; set; }  
 
		public Int32 CCnERPeriodId { get; set; }  
 
		public Nullable<Double> CCnERFixPrc { get; set; } 
    }
}


