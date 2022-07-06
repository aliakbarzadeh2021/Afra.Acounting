using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayMonthlyValsDto
    {
          
 
		public Int32 PayMonthlyValId { get; set; }  
 
		public Int32 PMVPersRef { get; set; }  
 
		public Int32 PMVElmntRef { get; set; }  
 
		public Int32 PMVIssueYear { get; set; }  
 
		public Int32 PMVIssueMonth { get; set; }  
 
		public Int32 PMVEffectYear { get; set; }  
 
		public Int32 PMVEffectMonth { get; set; }  
 
		public Nullable<Int32> PMVDayAmnt { get; set; }  
 
		public Nullable<Int32> PMVHourAmnt { get; set; }  
 
		public Nullable<Int32> PMVMinuteAmnt { get; set; }  
 
		public Nullable<Double> PMVAmount { get; set; }  
 
		public Nullable<Int32> PMVIYearMonth { get; set; }  
 
		public Nullable<Int32> PMVEYearMonth { get; set; }  
 
		public Nullable<Int32> PMVCreator { get; set; }  
 
		public Nullable<Int32> PMVSit { get; set; } 
    }
}


