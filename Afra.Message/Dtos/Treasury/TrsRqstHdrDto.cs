using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsRqstHdrDto
    {
          
 
		public Int32 TrsRqstHdrId { get; set; }  
 
		public String TRHRqstRef { get; set; }  
 
		public Int32 TRHNum { get; set; }  
 
		public Nullable<Int32> TRHLocalNum { get; set; }  
 
		public DateTime TRHDate { get; set; }  
 
		public String TRHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> TRHState { get; set; }  
 
		public Nullable<Int32> TQAccPrdRef { get; set; }  
 
		public Nullable<Int32> TRHCreator { get; set; }  
 
		public Nullable<Int32> TRHSit { get; set; } 
    }
}


