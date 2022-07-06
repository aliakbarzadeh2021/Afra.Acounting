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
    public class AddTrsVchSrcUseCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsVchSrcUseId { get; set; }  
 
		public Int32 TVSUItemRef { get; set; }  
 
		public Int32 TVSUSrcRef { get; set; }  
 
		public Double TVSUAmount { get; set; } 

        public void Validate()
        {
            new AddTrsVchSrcUseCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
