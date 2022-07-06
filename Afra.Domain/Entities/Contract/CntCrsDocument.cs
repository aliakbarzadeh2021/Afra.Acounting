using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntCrsDocument : BaseEntity
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


