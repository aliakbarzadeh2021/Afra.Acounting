using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayTaxComps : BaseEntity
    {
          
 
		public Int32 PayTaxCompId { get; set; }  
 
		public Nullable<Int32> PTCCompRef { get; set; }  
 
		public Nullable<Int32> PTCCompType { get; set; }  
 
		public Nullable<Int32> PTCCompKind { get; set; }  
 
		public String PTCBrnName { get; set; }  
 
		public String PTCPhone { get; set; }  
 
		public String PTCCode { get; set; }  
 
		public String PTCBrId { get; set; }  
 
		public String PTCFName1 { get; set; }  
 
		public String PTCLName1 { get; set; }  
 
		public String PTCNatCode1 { get; set; }  
 
		public String PTCPost1 { get; set; }  
 
		public String PTCFName2 { get; set; }  
 
		public String PTCLName2 { get; set; }  
 
		public String PTCNatCode2 { get; set; }  
 
		public String PTCPost2 { get; set; } 
    }
}


