using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoLttrDoc : BaseEntity
    {
          
 
		public Int32 OtoLttrDocId { get; set; }  
 
		public Int32 OLDLttrRef { get; set; }  
 
		public Int32 OLDDocType { get; set; }  
 
		public Byte[] OLDContent { get; set; }  
 
		public String OLDExt { get; set; }  
 
		public Nullable<Int32> OLDTemplate { get; set; } 
    }
}


