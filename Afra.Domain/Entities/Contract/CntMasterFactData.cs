using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntMasterFactData : BaseEntity
    {
          
 
		public Int32 CntMasterFactDataID { get; set; }  
 
		public Int32 CMFDFactRef { get; set; }  
 
		public Nullable<Int32> CMFDFldRef { get; set; }  
 
		public Nullable<Double> CMFDAmount { get; set; } 
    }
}


