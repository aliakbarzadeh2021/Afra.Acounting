using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleServices : BaseEntity
    {
          
 
		public Int32 SleServicesID { get; set; }  
 
		public String SSTitle { get; set; }  
 
		public Nullable<Int32> SSUnitRef { get; set; }  
 
		public String SSSLRef { get; set; }  
 
		public String SSDLRef { get; set; }  
 
		public String SSCode { get; set; }  
 
		public Nullable<Int32> SSGrpRef { get; set; }  
 
		public Nullable<Int32> SCDL4Type { get; set; }  
 
		public Nullable<Int32> SCDL5Type { get; set; }  
 
		public Nullable<Int32> SCDL6Type { get; set; } 
    }
}


