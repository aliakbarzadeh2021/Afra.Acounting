using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvPartCtgry : BaseEntity
    {
          
 
		public Int32 InvPartCtgryId { get; set; }  
 
		public String IPCCode { get; set; }  
 
		public String IPCName { get; set; }  
 
		public Int32 IPCPricingType { get; set; }  
 
		public String IPCSLRef { get; set; }  
 
		public Nullable<Int32> IPCDL4Type { get; set; }  
 
		public String IPCDL4Code { get; set; }  
 
		public Nullable<Int32> IPCDL5Type { get; set; }  
 
		public String IPCDL5Code { get; set; }  
 
		public Nullable<Int32> IPCDL6Type { get; set; }  
 
		public String IPCDL6Code { get; set; } 
    }
}


