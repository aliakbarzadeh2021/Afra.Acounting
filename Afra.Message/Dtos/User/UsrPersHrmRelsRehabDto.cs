using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class UsrPersHrmRelsRehabDto
    {
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String Relation { get; set; }  
 
		public String TDisease { get; set; }  
 
		public String BDate { get; set; }  
 
		public String Sick { get; set; }  
 
		public String MonthYear { get; set; }  
 
		public Nullable<Int32> Amount { get; set; } 
    }
}


