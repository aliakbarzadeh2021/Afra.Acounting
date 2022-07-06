using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class UsrBuyServiceDto
    {
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String DocNo { get; set; }  
 
		public String DocDate { get; set; }  
 
		public Nullable<Int32> DLRef { get; set; }  
 
		public String HDescr { get; set; } 
    }
}


