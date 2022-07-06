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
    public class AddSleBrokerSalaryMthdCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleBrokerSalaryMthdId { get; set; }  
 
		public Int32 SleBrokerSalaryRef { get; set; }  
 
		public Nullable<Int32> SBSMCstmrGrpRef { get; set; }  
 
		public Nullable<Int32> SBSMCstmrRef { get; set; }  
 
		public Nullable<Int32> SBSMPartGrpRef { get; set; }  
 
		public Nullable<Int32> SBSMPartRef { get; set; }  
 
		public Nullable<Int32> SBSMPlaceRef { get; set; }  
 
		public Nullable<Int32> SBSMSaleType { get; set; }  
 
		public Double SBSMFVal { get; set; }  
 
		public Double SBSMTVal { get; set; }  
 
		public Double SBSMValue { get; set; } 

        public void Validate()
        {
            new AddSleBrokerSalaryMthdCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
