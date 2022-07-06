using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntSrvPrcHdrDto
    {
          
 
		public Int32 CntSrvPrcHdrID { get; set; }  
 
		public Int32 CSPHNum { get; set; }  
 
		public Nullable<Int32> CSPHLocalNum { get; set; }  
 
		public DateTime CSPHDate { get; set; }  
 
		public String CSPHDescr { get; set; }  
 
		public Nullable<Int32> CSPHHaveEff { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> CSPHState { get; set; }  
 
		public Nullable<Int32> CSPAccPrdRef { get; set; } 
    }
}


