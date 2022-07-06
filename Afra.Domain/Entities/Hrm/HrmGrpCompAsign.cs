using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmGrpCompAsign : BaseEntity
    {
          
 
		public Int32 HrmGrpCompAsgnId { get; set; }  
 
		public Nullable<Int32> HGCAStatRef { get; set; }  
 
		public Nullable<Int32> HGCACompRef { get; set; }  
 
		public Nullable<Int32> HGCACompBrnRef { get; set; }  
 
		public Nullable<Int32> HGCAIsRel { get; set; } 
    }
}


