using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntInvoiceHdrDto
    {
          
 
		public Int32 CntInvoiceHdrId { get; set; }  
 
		public Int32 CIHType { get; set; }  
 
		public Int32 CIHExpAcntRef { get; set; }  
 
		public DateTime CIHDate { get; set; }  
 
		public Int32 CIHNum { get; set; }  
 
		public Int32 CIHCreator { get; set; }  
 
		public String CIHDescr { get; set; } 
    }
}


