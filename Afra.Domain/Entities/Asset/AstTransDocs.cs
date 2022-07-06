using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AstTransDocs : BaseEntity
    {
          
 
		public Int32 AstTrnDocId { get; set; }  
 
		public String AsDTType { get; set; }  
 
		public DateTime AsDTDate { get; set; }  
 
		public Int32 AsDTNum { get; set; }  
 
		public Nullable<Int32> AsDTLocalNum { get; set; }  
 
		public Nullable<Int32> AsDTGrpRef { get; set; }  
 
		public Nullable<Int32> AsDTPitchRef { get; set; }  
 
		public Nullable<Int32> AsDTMenRef { get; set; }  
 
		public Nullable<Int32> AsDTCostCenter { get; set; }  
 
		public Nullable<Int32> AsDTAccPrdRef { get; set; }  
 
		public String AsDTDescr { get; set; }  
 
		public Nullable<Int32> AsDTState { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; } 
    }
}


