using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UsrPersHrmRelsCons : BaseEntity
    {
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String Relation { get; set; }  
 
		public String LttrNo { get; set; }  
 
		public String DefDate { get; set; }  
 
		public String Reason { get; set; }  
 
		public String Conser { get; set; }  
 
		public Nullable<Int32> DefQty { get; set; }  
 
		public Nullable<Int32> SessionQty { get; set; }  
 
		public String Center { get; set; } 
    }
}


