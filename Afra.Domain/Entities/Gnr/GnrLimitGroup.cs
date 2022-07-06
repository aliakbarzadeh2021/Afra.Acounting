using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrLimitGroup : BaseEntity
    {
          
 
		public Int32 GnrLimitGroupId { get; set; }  
 
		public String GLGTitle { get; set; }  
 
		public String GLGName { get; set; }  
 
		public Int32 GLGSit { get; set; }  
 
		public String GLGObjView { get; set; }  
 
		public String GLGObjIdCol { get; set; }  
 
		public String GLGObjTitleCol { get; set; }  
 
		public String GLGObjTitle { get; set; } 
    }
}


