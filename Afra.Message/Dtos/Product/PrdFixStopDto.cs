using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PrdFixStopDto
    {
          
 
		public Int32 PrdFixStopId { get; set; }  
 
		public DateTime PFSFTime { get; set; }  
 
		public DateTime PFSTTime { get; set; }  
 
		public String PFSDescr { get; set; } 
    }
}


