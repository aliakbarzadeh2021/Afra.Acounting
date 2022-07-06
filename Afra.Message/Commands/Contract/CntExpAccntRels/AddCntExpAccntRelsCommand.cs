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
    public class AddCntExpAccntRelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CExRMastExpAcnRef { get; set; }  
 
		public Int32 CExRDetExpAcnRef { get; set; } 

        public void Validate()
        {
            new AddCntExpAccntRelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
