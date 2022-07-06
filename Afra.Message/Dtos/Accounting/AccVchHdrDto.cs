using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AccVchHdrDto
    {
          
 
		public Int32 AccVchHdrId { get; set; }  
 
		public Int32 AVHNum { get; set; }  
 
		public Int32 AVHTempNum { get; set; }  
 
		public Nullable<Int32> AVHLocalNum { get; set; }  
 
		public DateTime AVHDate { get; set; }  
 
		public String AVHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> VchState { get; set; }  
 
		public Nullable<Int32> AccPrdRef { get; set; }  
 
		public String AccSysRef { get; set; }  
 
		public Nullable<Int32> VchCtgry { get; set; }  
 
		public Nullable<Int32> AVHGrpRef { get; set; } 
    }
}


