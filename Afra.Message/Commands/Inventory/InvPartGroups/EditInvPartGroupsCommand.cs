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
    public class EditInvPartGroupsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvPartGroupsId { get; set; }  
 
		public Nullable<Int32> IPGParent { get; set; }  
 
		public String IPGCode { get; set; }  
 
		public String IPGTitle { get; set; }  
 
		public String IPGDLRef { get; set; }  
 
		public Nullable<Int32> IPGMainRoot { get; set; } 

        public void Validate()
        {
            new EditInvPartGroupsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
