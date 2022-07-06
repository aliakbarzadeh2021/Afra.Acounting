using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrRefFormsList : BaseEntity
    {
          
 
		public Int32 RefVchId { get; set; }  
 
		public String RVTitle { get; set; }  
 
		public String RVHdrViewName { get; set; }  
 
		public String RVItmViewName { get; set; }  
 
		public String RVHdrIdField { get; set; }  
 
		public String RVItmIdField { get; set; }  
 
		public String RVLinkStr { get; set; }  
 
		public String RVTitleCol { get; set; }  
 
		public String RVSystem { get; set; }  
 
		public String RVBaseSys { get; set; } 
    }
}


