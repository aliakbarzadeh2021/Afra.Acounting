using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntContElmnt : BaseEntity
    {
          
 
		public Int32 CntContElmntId { get; set; }  
 
		public Int32 CCEContRef { get; set; }  
 
		public Int32 CCEFldRef { get; set; }  
 
		public Nullable<Double> CCEAmount { get; set; } 
    }
}


