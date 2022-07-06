using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmPersExp : BaseEntity
    {
          
 
		public Int32 PersExpId { get; set; }  
 
		public Nullable<Int32> PersExpPersRef { get; set; }  
 
		public DateTime PersExpFDate { get; set; }  
 
		public DateTime PersExpTDate { get; set; }  
 
		public String PersExpExType { get; set; }  
 
		public String PersExpCompName { get; set; }  
 
		public Nullable<Int32> PersExpInsuDays { get; set; } 
    }
}


