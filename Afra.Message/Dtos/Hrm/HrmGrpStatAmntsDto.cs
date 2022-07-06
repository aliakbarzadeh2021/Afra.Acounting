using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmGrpStatAmntsDto
    {
          
 
		public Int32 HGSEElmntRef { get; set; }  
 
		public Int32 HGSEStatRef { get; set; }  
 
		public String HGSEFormula { get; set; }  
 
		public Nullable<Double> HGSEVal { get; set; }  
 
		public Nullable<Int32> HGSEWHRM { get; set; }  
 
		public DateTime HGSEEffDate { get; set; }  
 
		public Nullable<Int32> HGSEMthd { get; set; } 
    }
}


