using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntFormFields : BaseEntity
    {
          
 
		public Int32 CntFormFieldsId { get; set; }  
 
		public Int32 CFFType { get; set; }  
 
		public String CFFTitle { get; set; }  
 
		public Nullable<Int32> CFFCalcPr { get; set; }  
 
		public Nullable<Int32> CFFFieldOpr { get; set; } 
    }
}


