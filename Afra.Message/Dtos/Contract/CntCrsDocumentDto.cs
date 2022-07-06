using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntCrsDocumentDto
    {
          
 
		public Int32 CntCrsDocumentId { get; set; }  
 
		public Nullable<Int32> CCDDocType { get; set; }  
 
		public DateTime CCDDocDate { get; set; }  
 
		public Nullable<Int32> CCDBaseType { get; set; }  
 
		public Nullable<Int32> CCDItmRef { get; set; }  
 
		public String CCDNumber { get; set; }  
 
		public String CCDDescr { get; set; } 
    }
}


