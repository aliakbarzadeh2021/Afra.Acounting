using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrOrdHdrDto
    {
          
 
		public Int32 CmrOrdHdrId { get; set; }  
 
		public Int32 COHNum { get; set; }  
 
		public Nullable<Int32> COHLocalNum { get; set; }  
 
		public DateTime COHDate { get; set; }  
 
		public String COHDescr { get; set; }  
 
		public Nullable<Int32> COHBuyType { get; set; }  
 
		public Nullable<Int32> COHPersRef { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> COHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; } 
    }
}


