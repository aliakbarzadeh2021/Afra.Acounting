using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgElmntVal : BaseEntity
    {
          
 
		public Int32 BdgElmntValId { get; set; }  
 
		public Int32 BEVElmntRef { get; set; }  
 
		public String BEVDLRef { get; set; }  
 
		public String BEVDL5Ref { get; set; }  
 
		public String BEVDL6Ref { get; set; }  
 
		public String BEVDL7Ref { get; set; }  
 
		public Nullable<Int32> BEVPartRef { get; set; }  
 
		public Nullable<Int32> BEVFacType { get; set; }  
 
		public Nullable<Double> BEVQty { get; set; }  
 
		public Nullable<Double> BEVAmount { get; set; }  
 
		public Nullable<Int32> BTPeriodRef { get; set; }  
 
		public Nullable<Int32> BEVPeriodRef { get; set; }  
 
		public Nullable<Int32> BEVCurRef { get; set; } 
    }
}


