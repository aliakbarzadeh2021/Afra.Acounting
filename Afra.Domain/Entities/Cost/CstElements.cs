using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstElements : BaseEntity
    {
          
 
		public Int32 CstElmntId { get; set; }  
 
		public String CESLRef { get; set; }  
 
		public Nullable<Int32> CEType { get; set; }  
 
		public Nullable<Double> CEFixPrc { get; set; }  
 
		public Nullable<Double> CEChngPrc { get; set; } 
    }
}


