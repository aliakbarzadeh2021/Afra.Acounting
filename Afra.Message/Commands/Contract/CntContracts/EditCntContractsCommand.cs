using Afra.Message.Base;
using Afra.Message.Extentions;
using Afra.Message.Validators;
using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class EditCntContractsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntContId { get; set; }  
 
		public String CContNum { get; set; }  
 
		public DateTime CContDate { get; set; }  
 
		public Double CContAmount { get; set; }  
 
		public String CCSubjRef { get; set; }  
 
		public String CContDescr { get; set; }  
 
		public Int32 CContTavRef { get; set; }  
 
		public Int32 CContContractorRef { get; set; }  
 
		public String CContDur { get; set; }  
 
		public Nullable<Int32> CContHaveInq { get; set; }  
 
		public Nullable<Int32> CContHavePolicy { get; set; }  
 
		public Nullable<Double> CContPolicyAmnt { get; set; }  
 
		public Nullable<Double> CContCashAmnt { get; set; }  
 
		public Nullable<Double> CContGoodJobPrc { get; set; }  
 
		public String CContSupervisor { get; set; }  
 
		public Nullable<Int32> CContHaveInc { get; set; }  
 
		public Nullable<Int32> CContHaveBalance { get; set; }  
 
		public Nullable<Int32> CContSit { get; set; }  
 
		public String CContDLRef { get; set; }  
 
		public Nullable<Int32> CCAccPrdRef { get; set; }  
 
		public String CCInsuComp { get; set; }  
 
		public Nullable<Int32> CCGeoRef { get; set; }  
 
		public String CCTaxBranch { get; set; }  
 
		public DateTime CContEDate { get; set; } 

        public void Validate()
        {
            new EditCntContractsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
