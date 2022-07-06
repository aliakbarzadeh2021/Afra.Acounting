using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayGrpValStatAmntDto
    {
          
 
		public Int32 PGVSElmntRef { get; set; }  
 
		public Int32 PGVSStatRef { get; set; }  
 
		public Nullable<Double> PGVSAmount { get; set; }  
 
		public Nullable<Int32> PGVSSit { get; set; } 
    }
}


