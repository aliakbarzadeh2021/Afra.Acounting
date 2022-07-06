using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmEmpStatAmnt : BaseEntity
    {
          
 
		public Int32 HSAStatueRef { get; set; }  
 
		public Int32 HSAElmntRef { get; set; }  
 
		public Nullable<Double> HSAAmount { get; set; }  
 
		public DateTime HSAEffDate { get; set; }  
 
		public Nullable<Int32> HSAMthd { get; set; } 
    }
}


