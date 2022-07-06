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
    public class AddSleCstmrGroupsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleCstmrGroupId { get; set; }  
 
		public Nullable<Int32> SCGParent { get; set; }  
 
		public String SCGTitle { get; set; }  
 
		public String SCGDLRef { get; set; }  
 
		public Nullable<Int32> SCGMainRoot { get; set; } 

        public void Validate()
        {
            new AddSleCstmrGroupsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
