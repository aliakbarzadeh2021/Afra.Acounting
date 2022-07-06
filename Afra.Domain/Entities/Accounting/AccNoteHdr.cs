using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccNoteHdr : BaseEntity
    {
          
 
		public Int32 AccNoteHdrId { get; set; }  
 
		public Int32 ANHNum { get; set; }  
 
		public DateTime ANHDate { get; set; }  
 
		public String ANHDescr { get; set; }  
 
		public String ANHDLRef { get; set; } 
    }
}


