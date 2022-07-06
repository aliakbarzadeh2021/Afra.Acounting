using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsCreditTblDetDto
    {
          
 
		public Int32 TCTDHdrRef { get; set; }  
 
		public Double TCTDFVal { get; set; }  
 
		public Nullable<Double> TCTDTVal { get; set; }  
 
		public Nullable<Double> TCTDDirect { get; set; }  
 
		public Nullable<Double> TCTDInDirect { get; set; } 
    }
}


