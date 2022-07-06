using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Elements : BaseEntity
    {
          
 
		public Int32 ElmntId { get; set; }  
 
		public String ElmntTitle { get; set; }  
 
		public String ElmntType { get; set; }  
 
		public Int32 ElmntRole { get; set; }  
 
		public Nullable<Int32> ElmntFishPr { get; set; }  
 
		public Nullable<Int32> ElmntCalcPr { get; set; }  
 
		public Nullable<Int32> ElmntCompRef { get; set; }  
 
		public Nullable<Int32> ElmntStatPr { get; set; }  
 
		public Nullable<Int32> ElmntPayListPr { get; set; } 
    }
}


