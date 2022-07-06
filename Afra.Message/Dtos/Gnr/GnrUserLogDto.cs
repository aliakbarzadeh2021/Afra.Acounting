using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class GnrUserLogDto
    {
          
 
		public Int32 GnrUserLogId { get; set; }  
 
		public Int32 GULUserRef { get; set; }  
 
		public String GULCompName { get; set; }  
 
		public DateTime GULSDate { get; set; }  
 
		public Nullable<DateTime> GULEDate { get; set; }  
 
		public Int32 GULType { get; set; }  
 
		public String GULDescr { get; set; }  
 
		public Nullable<Int32> GULSPID { get; set; } 
    }
}


