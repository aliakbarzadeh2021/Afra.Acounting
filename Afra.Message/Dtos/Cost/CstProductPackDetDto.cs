using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstProductPackDetDto
    {
          
 
		public Int32 CstProdPackDetId { get; set; }  
 
		public Nullable<Int32> CPPDHdrRef { get; set; }  
 
		public Nullable<Int32> CPPDPartRef { get; set; }  
 
		public Nullable<Double> CPPDQty { get; set; }  
 
		public Nullable<Double> CPPDWast { get; set; } 
    }
}


