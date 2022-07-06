using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class UsrCrsOthInfDto
    {
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String PersCode { get; set; }  
 
		public String WorkLoc { get; set; }  
 
		public String ContType { get; set; }  
 
		public String AcntNo { get; set; }  
 
		public Nullable<Int32> BaygNo { get; set; } 
    }
}


