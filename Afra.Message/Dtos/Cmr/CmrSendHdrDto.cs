using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrSendHdrDto
    {
          
 
		public Int32 CmrSendHdrId { get; set; }  
 
		public Int32 CSHNum { get; set; }  
 
		public Nullable<Int32> CSHLocalNum { get; set; }  
 
		public DateTime CSHDate { get; set; }  
 
		public String CSHDescr { get; set; }  
 
		public Nullable<Int32> CSHDlvrRef { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CSHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; }  
 
		public Nullable<Int32> CSHRefID { get; set; }  
 
		public Nullable<Int32> CSHRefType { get; set; } 
    }
}


