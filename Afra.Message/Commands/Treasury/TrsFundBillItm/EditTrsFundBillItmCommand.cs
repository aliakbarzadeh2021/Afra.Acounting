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
    public class EditTrsFundBillItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFundBillItmId { get; set; }  
 
		public Nullable<Int32> TrsFundBillHdrRef { get; set; }  
 
		public Nullable<Int32> TFBISeq { get; set; }  
 
		public Nullable<Int32> TFBICostFactorRef { get; set; }  
 
		public Nullable<Int32> TFBIRqstNo { get; set; }  
 
		public DateTime TFBIRqstDate { get; set; }  
 
		public Nullable<Int32> TFBIFactNum { get; set; }  
 
		public DateTime TFBIFactDate { get; set; }  
 
		public String TFBIDescr { get; set; }  
 
		public Double TFBIFactAmnt { get; set; }  
 
		public String TFBIDLRef { get; set; }  
 
		public String TFBIDLFive { get; set; }  
 
		public String TFBIDLSix { get; set; } 

        public void Validate()
        {
            new EditTrsFundBillItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
