using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmRqstVac : BaseEntity
    {
          
 
		public Int32 HrmRqstVacId { get; set; }  
 
		public Nullable<Int32> HRVVacRef { get; set; }  
 
		public Nullable<Int32> HRVNum { get; set; }  
 
		public DateTime HRVDate { get; set; }  
 
		public Nullable<Int32> HRVPersRef { get; set; }  
 
		public Nullable<Int32> HRVType { get; set; }  
 
		public DateTime HRVFromDate { get; set; }  
 
		public DateTime HRVFromTime { get; set; }  
 
		public DateTime HRVToDate { get; set; }  
 
		public DateTime HRVToTime { get; set; } 
    }
}


