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
    public class EditTrsSourceUseCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsSourceUseID { get; set; }  
 
		public Nullable<Int32> TSUCode { get; set; }  
 
		public String TSUTitle { get; set; }  
 
		public String TSUSLRef { get; set; }  
 
		public String TSUDLRef { get; set; }  
 
		public String TSUDLFive { get; set; }  
 
		public String TSUDLSix { get; set; }  
 
		public Nullable<Int32> TSUType { get; set; } 

        public void Validate()
        {
            new EditTrsSourceUseCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
