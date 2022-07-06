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
    public class AddCntAccVchTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntAccVchTypeId { get; set; }  
 
		public String CAVTTitle { get; set; } 

        public void Validate()
        {
            new AddCntAccVchTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
