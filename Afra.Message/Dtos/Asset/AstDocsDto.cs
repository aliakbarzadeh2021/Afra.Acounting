using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AstDocsDto
    {
          
 
		public Int32 AstDocId { get; set; }  
 
		public String AsDType { get; set; }  
 
		public DateTime AsDDate { get; set; }  
 
		public Int32 AsDNum { get; set; }  
 
		public Nullable<Int32> AsDLocalNum { get; set; }  
 
		public Nullable<Int32> AsDGrpRef { get; set; }  
 
		public Nullable<Int32> AsDPitchRef { get; set; }  
 
		public Nullable<Int32> AsDMenRef { get; set; }  
 
		public Nullable<Int32> AsDCostCenter { get; set; }  
 
		public Nullable<Int32> AsDAccPrdRef { get; set; }  
 
		public String AsDDescr { get; set; }  
 
		public Nullable<Int32> AsDState { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; } 
    }
}


