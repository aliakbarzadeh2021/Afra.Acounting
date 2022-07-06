using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class InvVchTypesDto
    {
          
 
		public Int32 InvVchTypeId { get; set; }  
 
		public String IVTDescr { get; set; }  
 
		public String IVTDLType { get; set; }  
 
		public Nullable<Int32> IVTPricingType { get; set; }  
 
		public Nullable<Int32> IVTOpsAutoVch { get; set; }  
 
		public Nullable<Int32> IVTOAVStockRef { get; set; }  
 
		public Nullable<Int32> IVTOAVDLRef { get; set; }  
 
		public Nullable<Int32> IVTPartLimit { get; set; }  
 
		public Nullable<Int32> IVTBaseLimit { get; set; }  
 
		public Nullable<Int32> IVTShopRel { get; set; } 
    }
}


