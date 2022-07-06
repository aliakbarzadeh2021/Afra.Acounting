using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UsrPersHrmRelsAppl : BaseEntity
    {
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String Cause { get; set; }  
 
		public String LttrNo { get; set; }  
 
		public String LttrDate { get; set; }  
 
		public String Appler { get; set; }  
 
		public String Oprs { get; set; } 
    }
}


