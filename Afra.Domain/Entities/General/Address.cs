using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Address : BaseEntity
    {
          
 
		public Int32 AddressId { get; set; }  
 
		public Int32 AdCrsRef { get; set; }  
 
		public Nullable<Int32> AdGeoRef { get; set; }  
 
		public String AdDescr { get; set; }  
 
		public String AdPhone1 { get; set; }  
 
		public String AdPhone2 { get; set; }  
 
		public String AdMobile { get; set; }  
 
		public String AdFax { get; set; }  
 
		public String AdPostCode { get; set; }  
 
		public String AdEMail { get; set; } 
    }
}


