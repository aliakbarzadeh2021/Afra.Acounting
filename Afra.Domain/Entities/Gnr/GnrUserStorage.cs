using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrUserStorage : BaseEntity
    {
          
 
		public String GUSFormRef { get; set; }  
 
		public Int32 GUSUserRef { get; set; }  
 
		public Int32 GUSType { get; set; }  
 
		public String GUSValue { get; set; } 
    }
}


