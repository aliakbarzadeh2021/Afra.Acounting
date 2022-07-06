using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmEmpStatAmntDto
    {
          
 
		public Int32 HSAStatueRef { get; set; }  
 
		public Int32 HSAElmntRef { get; set; }  
 
		public Nullable<Double> HSAAmount { get; set; }  
 
		public DateTime HSAEffDate { get; set; }  
 
		public Nullable<Int32> HSAMthd { get; set; } 
    }
}


