using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayExportFilesDto
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


