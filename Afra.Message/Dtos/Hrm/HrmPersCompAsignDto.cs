using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmPersCompAsignDto
    {
          
 
		public Int32 HrmPersCompAsgnId { get; set; }  
 
		public Nullable<Int32> HPCAEmpStatRef { get; set; }  
 
		public Nullable<Int32> HPCACompRef { get; set; }  
 
		public Nullable<Int32> HPCACompBrnRef { get; set; }  
 
		public Nullable<Int32> HPCAIsRel { get; set; }  
 
		public String HPCAPersId { get; set; } 
    }
}


