using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgTopicsRelsDto
    {
          
 
		public Int32 BdgTopicsRelsId { get; set; }  
 
		public Int32 BTRTopicRef { get; set; }  
 
		public Int32 BTRType { get; set; }  
 
		public String BTRSLRef { get; set; }  
 
		public String BTRDLRef { get; set; }  
 
		public String BTRDL5Ref { get; set; }  
 
		public String BTRDL6Ref { get; set; }  
 
		public String BTRDL7Ref { get; set; }  
 
		public Nullable<Int32> BTPeriodRef { get; set; } 
    }
}


