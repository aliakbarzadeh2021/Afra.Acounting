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
    public class EditSleSrvGroupsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleSrvGroupsId { get; set; }  
 
		public Nullable<Int32> SSGParent { get; set; }  
 
		public String SSGCode { get; set; }  
 
		public String SSGTitle { get; set; }  
 
		public String SSGDLRef { get; set; }  
 
		public Nullable<Int32> SSGMainRoot { get; set; } 

        public void Validate()
        {
            new EditSleSrvGroupsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
