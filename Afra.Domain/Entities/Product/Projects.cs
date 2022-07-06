using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Projects : BaseEntity
    {
          
 
		public Int32 ProjectId { get; set; }  
 
		public String PrjCode { get; set; }  
 
		public String PrjName { get; set; }  
 
		public String PrjDLRef { get; set; } 
    }
}


