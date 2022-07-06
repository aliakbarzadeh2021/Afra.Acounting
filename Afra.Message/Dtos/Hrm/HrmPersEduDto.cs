using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmPersEduDto
    {
          
 
		public Int32 PersEduId { get; set; }  
 
		public Nullable<Int32> PEdPersRef { get; set; }  
 
		public String PersEduDeg { get; set; }  
 
		public DateTime PersEduDate { get; set; }  
 
		public String PersEduField { get; set; }  
 
		public String PersEduUnv { get; set; }  
 
		public Nullable<Double> PersEduAvg { get; set; }  
 
		public String PersEduTrend { get; set; } 
    }
}


