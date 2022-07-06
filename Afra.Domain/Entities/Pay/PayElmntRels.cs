using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayElmntRels : BaseEntity
    {
          
 
		public Int32 PayElmntRelId { get; set; }  
 
		public Int32 PERType { get; set; }  
 
		public String PERName { get; set; }  
 
		public Nullable<Int32> PERElmntRef { get; set; }  
 
		public Nullable<Int32> PERRole { get; set; } 
    }
}


