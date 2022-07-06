using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstPeriodsDto
    {
          
 
		public Int32 CstPeriodId { get; set; }  
 
		public String CPTitle { get; set; }  
 
		public DateTime CPFromDate { get; set; }  
 
		public DateTime CPToDate { get; set; }  
 
		public Nullable<Int32> CPState { get; set; }  
 
		public Nullable<Int32> CPWrkDay { get; set; } 
    }
}


