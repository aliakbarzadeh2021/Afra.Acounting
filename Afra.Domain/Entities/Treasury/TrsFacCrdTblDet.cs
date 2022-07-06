using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFacCrdTblDet : BaseEntity
    {
          
 
		public Int32 TFCTDHdrRef { get; set; }  
 
		public Double TFCTDFVal { get; set; }  
 
		public Nullable<Double> TFCTDTVal { get; set; }  
 
		public Nullable<Double> TFCTDDirect { get; set; }  
 
		public Nullable<Double> TFCTDInDirect { get; set; } 
    }
}


