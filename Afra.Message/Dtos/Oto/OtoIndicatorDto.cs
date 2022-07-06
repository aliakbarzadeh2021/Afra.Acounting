using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class OtoIndicatorDto
    {
          
 
		public Int32 OtoIndicatorId { get; set; }  
 
		public String OIDescr { get; set; }  
 
		public Int32 OIStartNo { get; set; }  
 
		public Int32 OISeed { get; set; }  
 
		public String OIPattern { get; set; }  
 
		public DateTime OIStartDate { get; set; }  
 
		public DateTime OIEndDate { get; set; } 
    }
}


