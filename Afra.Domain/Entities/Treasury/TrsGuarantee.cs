using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsGuarantee : BaseEntity
    {
          
 
		public Int32 TrsGuaranteeId { get; set; }  
 
		public Int32 TGContRef { get; set; }  
 
		public Int32 TGKind { get; set; }  
 
		public String TGNum { get; set; }  
 
		public DateTime TGIssuDate { get; set; }  
 
		public DateTime TGEffDate { get; set; }  
 
		public Double TGAmount { get; set; }  
 
		public Nullable<Double> TGDeposit { get; set; }  
 
		public Nullable<Double> TGCharge { get; set; }  
 
		public Nullable<Int32> TGBankAccRef { get; set; }  
 
		public String TGDescr { get; set; }  
 
		public String TGDLRef { get; set; }  
 
		public Nullable<Int32> TGState { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Double> TGChargeTax { get; set; }  
 
		public Nullable<Double> TGChargeDuty { get; set; }  
 
		public String TGSerNo { get; set; }  
 
		public String TGSepNo { get; set; }  
 
		public String TGBenefy { get; set; }  
 
		public Nullable<Double> TGDepRate { get; set; }  
 
		public Nullable<Double> TGChargeRate { get; set; }  
 
		public Nullable<Int32> TGCreator { get; set; }  
 
		public Nullable<Int32> TGSit { get; set; } 
    }
}


