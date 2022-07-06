using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntExpAcntValsDto
    {
          
 
		public Int32 CntExpAcntValId { get; set; }  
 
		public Int32 CEAVFldRef { get; set; }  
 
		public Int32 CEAVExpAcntRef { get; set; }  
 
		public Nullable<Double> CEAVAmount { get; set; }  
 
		public Nullable<Int32> CEAVFormulRef { get; set; }  
 
		public Nullable<Double> CEAVCurVal { get; set; } 
    }
}


