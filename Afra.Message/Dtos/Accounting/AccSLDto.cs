using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AccSLDto
    {
          
 
		public String sl_Code { get; set; }  
 
		public String sl_Title { get; set; }  
 
		public String GlRef { get; set; }  
 
		public String sl_BalanceType { get; set; }  
 
		public Nullable<Int32> sl_HaveQty { get; set; }  
 
		public Nullable<Int32> sl_HaveCur { get; set; } 
    }
}


