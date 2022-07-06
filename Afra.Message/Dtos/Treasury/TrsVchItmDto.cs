using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsVchItmDto
    {
          
 
		public Int32 TrsVchItmId { get; set; }  
 
		public Nullable<Int32> TrsVchHdrRef { get; set; }  
 
		public Int32 TVIAccOprRef { get; set; }  
 
		public Nullable<Int32> TVICashFactRef { get; set; }  
 
		public Nullable<Int32> TVIBankAccRef { get; set; }  
 
		public Nullable<Int32> TVIBankRef { get; set; }  
 
		public String TVIBranchName { get; set; }  
 
		public Nullable<Int32> TVICashRef { get; set; }  
 
		public Nullable<Int32> TVIChqRef { get; set; }  
 
		public String TVIDLRef { get; set; }  
 
		public Nullable<Int32> TVISeq { get; set; }  
 
		public String TVIItmNo { get; set; }  
 
		public String TVIDescr { get; set; }  
 
		public DateTime TVIDate { get; set; }  
 
		public Double TVIQty { get; set; }  
 
		public String TVIItmType { get; set; }  
 
		public String TVIBankAcnName { get; set; }  
 
		public Nullable<Int32> TVIItmRef { get; set; }  
 
		public Nullable<Int32> TVIOpsBankAcn { get; set; }  
 
		public Nullable<Int32> TVIOpsCash { get; set; }  
 
		public Nullable<Int32> TVIOpsFund { get; set; }  
 
		public Nullable<Int32> TVIRefID { get; set; }  
 
		public Nullable<Int32> TVIRefType { get; set; }  
 
		public Nullable<Int32> TVIItmRole { get; set; }  
 
		public String TVIDLFive { get; set; }  
 
		public String TVIDLSix { get; set; }  
 
		public Nullable<Int32> TVICurRef { get; set; }  
 
		public Nullable<Double> TVICurVal { get; set; } 
    }
}


