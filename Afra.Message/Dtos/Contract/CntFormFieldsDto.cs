using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntFormFieldsDto
    {
          
 
		public Int32 CntFormFieldsId { get; set; }  
 
		public Int32 CFFType { get; set; }  
 
		public String CFFTitle { get; set; }  
 
		public Nullable<Int32> CFFCalcPr { get; set; }  
 
		public Nullable<Int32> CFFFieldOpr { get; set; } 
    }
}


