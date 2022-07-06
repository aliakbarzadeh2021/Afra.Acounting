using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class InvPartCmrInfDto
    {
          
 
		public Int32 InvPartCmrInfId { get; set; }  
 
		public Nullable<Int32> IPCIStockRef { get; set; }  
 
		public Nullable<Int32> IPCIPartRef { get; set; }  
 
		public Nullable<Double> IPCIMinQty { get; set; }  
 
		public Nullable<Double> IPCIMaxQty { get; set; }  
 
		public Nullable<Double> IPCIOrderLimit { get; set; }  
 
		public Nullable<Double> IPCIOrderQty { get; set; } 
    }
}


