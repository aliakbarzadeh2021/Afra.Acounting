using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UsrPersHrmRelsDoc : BaseEntity
    {
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String TestDate { get; set; }  
 
		public String Result { get; set; }  
 
		public String NextDate { get; set; }  
 
		public String City { get; set; }  
 
		public String JobType { get; set; }  
 
		public String Descr { get; set; } 
    }
}


