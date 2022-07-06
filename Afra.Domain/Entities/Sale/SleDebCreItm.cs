using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleDebCreItm : BaseEntity
    {
          
 
		public Int32 SleDebCreItmId { get; set; }  
 
		public Nullable<Int32> SleDebCreHdrRef { get; set; }  
 
		public Nullable<Int32> SDCISeq { get; set; }  
 
		public Nullable<Int32> SDCIRole { get; set; }  
 
		public String SDCIDebSL { get; set; }  
 
		public String SDCIDebDL { get; set; }  
 
		public String SDCIDebDL5 { get; set; }  
 
		public String SDCIDebDL6 { get; set; }  
 
		public String SDCICreSL { get; set; }  
 
		public String SDCICreDL { get; set; }  
 
		public String SDCICreDL5 { get; set; }  
 
		public String SDCICreDL6 { get; set; }  
 
		public Nullable<Double> SDCIAmount { get; set; }  
 
		public String SDCIDescr { get; set; } 
    }
}


