using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleDebCreHdrDto
    {
          
 
		public Int32 SleDebCreHdrId { get; set; }  
 
		public Int32 SDCHBranchRef { get; set; }  
 
		public Int32 SDCHType { get; set; }  
 
		public Int32 SDCHNum { get; set; }  
 
		public Nullable<Int32> SDCHLocalNum { get; set; }  
 
		public DateTime SDCHDate { get; set; }  
 
		public String SDCHDescr { get; set; }  
 
		public Nullable<Int32> SDCHAccPrd { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> SDCHState { get; set; } 
    }
}


