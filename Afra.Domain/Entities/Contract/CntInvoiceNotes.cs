using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntInvoiceNotes : BaseEntity
    {
          
 
		public Int32 CntInvoiceNoteId { get; set; }  
 
		public String CINTitle { get; set; }  
 
		public String CINFormul { get; set; } 
    }
}


