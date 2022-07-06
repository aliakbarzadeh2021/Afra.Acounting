using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsCreditTblDet : BaseEntity
    {
          
 
		public Int32 TCTDHdrRef { get; set; }  
 
		public Double TCTDFVal { get; set; }  
 
		public Nullable<Double> TCTDTVal { get; set; }  
 
		public Nullable<Double> TCTDDirect { get; set; }  
 
		public Nullable<Double> TCTDInDirect { get; set; } 
    }
}


