using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class ShopsDto
    {
          
 
		public Int32 ShopsId { get; set; }  
 
		public String ShopName { get; set; }  
 
		public String ShopDb { get; set; }  
 
		public Nullable<Int32> ShopSaleBranch { get; set; }  
 
		public Nullable<Int32> ShopStock { get; set; } 
    }
}


