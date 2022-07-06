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
    public class AddCntInvoiceRelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntInvoiceRelId { get; set; }  
 
		public String CIRLabel { get; set; }  
 
		public String CIRRatioField { get; set; }  
 
		public String CIRCalcField { get; set; }  
 
		public String CIRPayField { get; set; }  
 
		public String CIRPayAccCode { get; set; }  
 
		public Nullable<Int32> CIRHaveRet { get; set; }  
 
		public Nullable<Int32> CIRPriovity { get; set; }  
 
		public Int32 CIROprType { get; set; }  
 
		public Nullable<Int32> CIRRetCtrl { get; set; }  
 
		public Nullable<Int32> CIRRetCtrl2 { get; set; }  
 
		public Nullable<Int32> CIRCheckDate { get; set; } 

        public void Validate()
        {
            new AddCntInvoiceRelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
