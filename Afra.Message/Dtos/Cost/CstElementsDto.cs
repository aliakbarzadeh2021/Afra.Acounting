using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstElementsDto
    {
          
 
		public Int32 CstElmntId { get; set; }  
 
		public String CESLRef { get; set; }  
 
		public Nullable<Int32> CEType { get; set; }  
 
		public Nullable<Double> CEFixPrc { get; set; }  
 
		public Nullable<Double> CEChngPrc { get; set; } 
    }
}


