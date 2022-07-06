using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrInvoiceHdrDto
    {
          
 
		public Int32 CmrInvoiceHdrId { get; set; }  
 
		public Int32 CIHNum { get; set; }  
 
		public Nullable<Int32> CIHLocalNum { get; set; }  
 
		public DateTime CIHDate { get; set; }  
 
		public String CIHDescr { get; set; }  
 
		public Nullable<Int32> CIHSellerRef { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CIHState { get; set; }  
 
		public Nullable<Int32> CAccPrdRef { get; set; }  
 
		public Nullable<Int32> CIHRefID { get; set; }  
 
		public Nullable<Int32> CIHRefType { get; set; }  
 
		public Nullable<Int32> CIHCurRef { get; set; }  
 
		public Nullable<Double> CIHCurRate { get; set; } 
    }
}


