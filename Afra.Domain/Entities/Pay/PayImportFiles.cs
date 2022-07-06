using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayImportFiles : BaseEntity
    {
          
 
		public Int32 PayImpFileId { get; set; }  
 
		public String PIFTitle { get; set; }  
 
		public Nullable<Int32> PIFFormat { get; set; }  
 
		public String PIFPCFldName { get; set; }  
 
		public Nullable<Int32> PIFPCStart { get; set; }  
 
		public Nullable<Int32> PIFPCCnt { get; set; } 
    }
}


