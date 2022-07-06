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
    public class EditGnrSysFormsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SystemFormID { get; set; }  
 
		public String SFName { get; set; }  
 
		public String SFSystemRef { get; set; }  
 
		public String SFTitle { get; set; }  
 
		public String SFTableName { get; set; } 

        public void Validate()
        {
            new EditGnrSysFormsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
