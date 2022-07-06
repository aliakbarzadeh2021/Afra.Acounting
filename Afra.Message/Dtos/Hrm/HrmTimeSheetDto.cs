using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmTimeSheetDto
    {
          
 
		public Int32 HTSPersRef { get; set; }  
 
		public DateTime HTSDate { get; set; }  
 
		public DateTime HTSEnt1 { get; set; }  
 
		public DateTime HTSExt1 { get; set; }  
 
		public DateTime HTSEnt2 { get; set; }  
 
		public DateTime HTSExt2 { get; set; }  
 
		public DateTime HTSEnt3 { get; set; }  
 
		public DateTime HTSExt3 { get; set; }  
 
		public Nullable<Int32> HTSVac1Type { get; set; }  
 
		public DateTime HTSVacBg1 { get; set; }  
 
		public DateTime HTSVacEx1 { get; set; }  
 
		public Nullable<Int32> HTSVac2Type { get; set; }  
 
		public DateTime HTSVacBg2 { get; set; }  
 
		public DateTime HTSVacEx2 { get; set; }  
 
		public Nullable<Int32> HTSMis1Type { get; set; }  
 
		public DateTime HTSMisBg1 { get; set; }  
 
		public DateTime HTSMisEx1 { get; set; }  
 
		public Nullable<Int32> HTSMis2Type { get; set; }  
 
		public DateTime HTSMisBg2 { get; set; }  
 
		public DateTime HTSMisEx2 { get; set; } 
    }
}


