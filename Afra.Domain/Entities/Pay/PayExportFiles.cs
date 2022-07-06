using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayExportFiles : BaseEntity
    {
          
 
		public Int32 PayExpFileId { get; set; }  
 
		public String PEFTitle { get; set; }  
 
		public String PEFName { get; set; }  
 
		public String PEFDelimt { get; set; }  
 
		public Nullable<Int32> PEFFixName { get; set; }  
 
		public String PEFDefPath { get; set; }  
 
		public Nullable<Int32> PEFBankRef { get; set; } 
    }
}


