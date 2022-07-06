using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AstCostDocs : BaseEntity
    {
          
 
		public Int32 AstCstDocId { get; set; }  
 
		public String AsDCType { get; set; }  
 
		public DateTime AsDCDate { get; set; }  
 
		public Int32 AsDCNum { get; set; }  
 
		public Nullable<Int32> AsDCLocalNum { get; set; }  
 
		public String AsDCDescr { get; set; }  
 
		public Nullable<Int32> AsDCState { get; set; }  
 
		public Nullable<Int32> AsDCAccPrdRef { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; } 
    }
}


