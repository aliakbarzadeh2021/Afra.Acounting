using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class UsrvchBaseInfoDto
    {
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String ReqUser { get; set; }  
 
		public Nullable<Int32> Stp1 { get; set; }  
 
		public Nullable<Int32> Step2 { get; set; }  
 
		public String Descr { get; set; } 
    }
}


