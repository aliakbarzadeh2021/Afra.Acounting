using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoAttach : BaseEntity
    {
          
 
		public Int32 OtoAttachId { get; set; }  
 
		public Int32 OARefType { get; set; }  
 
		public Int32 OARefId { get; set; }  
 
		public Int32 OAType { get; set; }  
 
		public Nullable<Int32> OABaseId { get; set; }  
 
		public String OADescr { get; set; }  
 
		public Byte[] OAFileContent { get; set; }  
 
		public String OAFileExt { get; set; } 
    }
}


