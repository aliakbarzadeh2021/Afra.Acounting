using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmPersRltdDto
    {
          
 
		public Int32 PersRltdId { get; set; }  
 
		public Nullable<Int32> PersRltdPersRef { get; set; }  
 
		public DateTime PersRltdBDate { get; set; }  
 
		public String PersRltdFullName { get; set; }  
 
		public String PersRltdType { get; set; }  
 
		public Nullable<Int32> PersRltdHaveInsu { get; set; } 
    }
}


