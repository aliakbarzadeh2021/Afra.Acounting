using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoQuickNote : BaseEntity
    {
          
 
		public Int32 OtoQuickNoteId { get; set; }  
 
		public String OQNTitle { get; set; }  
 
		public Byte[] OQNText { get; set; } 
    }
}


