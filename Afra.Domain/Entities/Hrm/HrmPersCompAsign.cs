using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmPersCompAsign : BaseEntity
    {
          
 
		public Int32 HrmPersCompAsgnId { get; set; }  
 
		public Nullable<Int32> HPCAEmpStatRef { get; set; }  
 
		public Nullable<Int32> HPCACompRef { get; set; }  
 
		public Nullable<Int32> HPCACompBrnRef { get; set; }  
 
		public Nullable<Int32> HPCAIsRel { get; set; }  
 
		public String HPCAPersId { get; set; } 
    }
}


