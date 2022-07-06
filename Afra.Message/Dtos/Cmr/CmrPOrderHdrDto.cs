using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrPOrderHdrDto
    {
          
 
		public Int32 CmrPOrderHdrId { get; set; }  
 
		public Int32 CPOHNum { get; set; }  
 
		public Nullable<Int32> CPOHLocalNum { get; set; }  
 
		public Nullable<Int32> CPOHPreFactRef { get; set; }  
 
		public DateTime CPOHDate { get; set; }  
 
		public String CPOHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CPOHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; }  
 
		public Nullable<Int32> CPOHCurRef { get; set; } 
    }
}


