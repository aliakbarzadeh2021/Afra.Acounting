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
    public class AddProjectsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ProjectId { get; set; }  
 
		public String PrjCode { get; set; }  
 
		public String PrjName { get; set; }  
 
		public String PrjDLRef { get; set; } 

        public void Validate()
        {
            new AddProjectsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
