using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmJobsDto
    {
          
 
		public Int32 JobId { get; set; }  
 
		public String JobCode { get; set; }  
 
		public String JobTitle { get; set; }  
 
		public Nullable<Int32> JPayGrpRef { get; set; }  
 
		public String JHardJobCode { get; set; }  
 
		public Nullable<Double> JobPoint { get; set; }  
 
		public Nullable<Int32> JobOthCode { get; set; } 
    }
}


