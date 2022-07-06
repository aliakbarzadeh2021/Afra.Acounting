using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFundOpr : BaseEntity
    {
          
 
		public Int32 TrsFundOprId { get; set; }  
 
		public Nullable<Int32> TFONum { get; set; }  
 
		public DateTime TFODate { get; set; }  
 
		public Int32 TFOFundRef { get; set; }  
 
		public String TFODescr { get; set; }  
 
		public Int32 TFOType { get; set; }  
 
		public Int32 TFOOpsId { get; set; }  
 
		public Nullable<Double> TFOAmount { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> TFOState { get; set; }  
 
		public Nullable<Int32> TFOAccPrdRef { get; set; }  
 
		public Nullable<Int32> TFOTrsVchRef { get; set; }  
 
		public Nullable<Int32> TFOFundBillRef { get; set; }  
 
		public Nullable<Int32> TFOCreator { get; set; }  
 
		public Nullable<Int32> TFOSit { get; set; } 
    }
}


