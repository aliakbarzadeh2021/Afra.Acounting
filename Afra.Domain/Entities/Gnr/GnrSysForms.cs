using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrSysForms : BaseEntity
    {
          
 
		public Int32 SystemFormID { get; set; }  
 
		public String SFName { get; set; }  
 
		public String SFSystemRef { get; set; }  
 
		public String SFTitle { get; set; }  
 
		public String SFTableName { get; set; } 
    }
}


