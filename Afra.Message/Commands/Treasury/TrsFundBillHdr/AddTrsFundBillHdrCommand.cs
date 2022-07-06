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
    public class AddTrsFundBillHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFundBillHdrId { get; set; }  
 
		public Int32 TFBHFundRef { get; set; }  
 
		public Int32 TFBHNum { get; set; }  
 
		public Nullable<Int32> TFBHLocalNum { get; set; }  
 
		public DateTime TFBHDate { get; set; }  
 
		public String TFBHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> TFBHState { get; set; }  
 
		public Nullable<Int32> TBAccPrdRef { get; set; }  
 
		public Nullable<Int32> TFBTrans { get; set; }  
 
		public Nullable<Int32> TFBHCreator { get; set; }  
 
		public Nullable<Int32> TFBHSit { get; set; } 

        public void Validate()
        {
            new AddTrsFundBillHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
