using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PrdFixInfDto
    {
          
 
		public Int32 PrdFixInfID { get; set; }  
 
		public Nullable<Int32> PFIProdVchType { get; set; }  
 
		public Nullable<Int32> PFIExpnsVchType { get; set; }  
 
		public Nullable<Int32> PFIMatStkRef { get; set; }  
 
		public Nullable<Int32> PFIPrdStkRef { get; set; }  
 
		public Nullable<Int32> PFISemiStkRef { get; set; }  
 
		public Nullable<Int32> PFIBaseVchType { get; set; } 
    }
}


