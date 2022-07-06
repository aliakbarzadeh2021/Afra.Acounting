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
    public class EditInvStckTagCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvStckTagId { get; set; }  
 
		public Nullable<Int32> ISTTagNo { get; set; }  
 
		public Int32 ISTStckPeriodRef { get; set; }  
 
		public Int32 ISTStockRef { get; set; }  
 
		public Nullable<Int32> ISTPartRef { get; set; }  
 
		public Nullable<Double> ISTTagCnt1 { get; set; }  
 
		public Nullable<Double> ISTTagCnt2 { get; set; }  
 
		public Nullable<Double> ISTTagCnt3 { get; set; }  
 
		public Nullable<Int32> ISTInvVchItmRef { get; set; } 

        public void Validate()
        {
            new EditInvStckTagCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
