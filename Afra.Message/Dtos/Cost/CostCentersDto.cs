using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CostCentersDto
    {
          
 
		public Int32 CostCenterID { get; set; }  
 
		public String CstCode { get; set; }  
 
		public String CstName { get; set; }  
 
		public String CstDLRef { get; set; }  
 
		public Nullable<Int32> CstType { get; set; } 
    }
}


