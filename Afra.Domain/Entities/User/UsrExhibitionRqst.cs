using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UsrExhibitionRqst : BaseEntity
    {
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String FullName { get; set; }  
 
		public String BDate { get; set; }  
 
		public String Subject { get; set; }  
 
		public Nullable<Int32> Shora { get; set; }  
 
		public Nullable<Int32> SaleRqst { get; set; }  
 
		public Nullable<Int32> RqstGavahi { get; set; }  
 
		public Nullable<Int32> OrdAmnt { get; set; }  
 
		public String Acept { get; set; } 
    }
}


