using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AstAssetInfDto
    {
          
 
		public Int32 AstAssetInfId { get; set; }  
 
		public Nullable<Int32> AstDocTransRef { get; set; }  
 
		public Int32 AAIAstRef { get; set; }  
 
		public String AAIType { get; set; }  
 
		public DateTime AAIDate { get; set; }  
 
		public Nullable<Int32> AAIGrpRef { get; set; }  
 
		public Nullable<Int32> AAIPitchRef { get; set; }  
 
		public Nullable<Int32> AAIMenRef { get; set; }  
 
		public Nullable<Int32> AAICstRef { get; set; }  
 
		public String AAIAstState { get; set; }  
 
		public String AAIResponse { get; set; } 
    }
}


