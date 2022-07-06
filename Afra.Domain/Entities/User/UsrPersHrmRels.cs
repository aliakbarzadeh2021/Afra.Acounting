using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UsrPersHrmRels : BaseEntity
    {
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String PersCode { get; set; }  
 
		public String FullName { get; set; }  
 
		public String NatCode { get; set; }  
 
		public String EmpDate { get; set; }  
 
		public String CostCenter { get; set; }  
 
		public String WorkLoc { get; set; }  
 
		public String Job { get; set; } 
    }
}


