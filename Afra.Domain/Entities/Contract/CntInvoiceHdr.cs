using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntInvoiceHdr : BaseEntity
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


