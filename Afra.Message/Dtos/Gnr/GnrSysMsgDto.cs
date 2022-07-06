using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class GnrSysMsgDto
    {
          
 
		public Int32 GnrSysMsgId { get; set; }  
 
		public String GSMTitle { get; set; }  
 
		public String GSMDescr { get; set; }  
 
		public DateTime GSMSDate { get; set; }  
 
		public DateTime GSMEDate { get; set; }  
 
		public Nullable<Int32> GSMType { get; set; }  
 
		public Int32 GSMCreator { get; set; } 
    }
}


