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
    public class EditPayBuyCalcCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayBuyCalcId { get; set; }  
 
		public Int32 PBCPersRef { get; set; }  
 
		public Double PBCBaseVal { get; set; }  
 
		public Int32 PBCDays { get; set; } 

        public void Validate()
        {
            new EditPayBuyCalcCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
