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
    public class EditPayElmntRelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayElmntRelId { get; set; }  
 
		public Int32 PERType { get; set; }  
 
		public String PERName { get; set; }  
 
		public Nullable<Int32> PERElmntRef { get; set; }  
 
		public Nullable<Int32> PERRole { get; set; } 

        public void Validate()
        {
            new EditPayElmntRelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
