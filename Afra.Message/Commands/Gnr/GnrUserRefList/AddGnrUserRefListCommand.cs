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
    public class AddGnrUserRefListCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrUserRefListId { get; set; }  
 
		public String GURLTitle { get; set; }  
 
		public String GURLViewName { get; set; }  
 
		public String GURLIdFieldName { get; set; }  
 
		public String GURLDesFieldName { get; set; } 

        public void Validate()
        {
            new AddGnrUserRefListCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
