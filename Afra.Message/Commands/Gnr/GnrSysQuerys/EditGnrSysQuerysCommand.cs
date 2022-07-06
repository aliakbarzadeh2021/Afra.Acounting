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
    public class EditGnrSysQuerysCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrSysQryId { get; set; }  
 
		public String GSQTitle { get; set; }  
 
		public String GSQView { get; set; }  
 
		public String GSQSysRef { get; set; } 

        public void Validate()
        {
            new EditGnrSysQuerysCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
