using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayGrpValStatAmnt : BaseEntity
    {
          
 
		public Int32 PGVSElmntRef { get; set; }  
 
		public Int32 PGVSStatRef { get; set; }  
 
		public Nullable<Double> PGVSAmount { get; set; }  
 
		public Nullable<Int32> PGVSSit { get; set; } 
    }
}


