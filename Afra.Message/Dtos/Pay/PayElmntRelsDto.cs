using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayElmntRelsDto
    {
          
 
		public Int32 PayElmntRelId { get; set; }  
 
		public Int32 PERType { get; set; }  
 
		public String PERName { get; set; }  
 
		public Nullable<Int32> PERElmntRef { get; set; }  
 
		public Nullable<Int32> PERRole { get; set; } 
    }
}


