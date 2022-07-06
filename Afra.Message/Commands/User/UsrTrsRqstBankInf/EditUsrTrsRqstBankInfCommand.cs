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
    public class EditUsrTrsRqstBankInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String Shaba { get; set; }  
 
		public String AcnNo { get; set; }  
 
		public String CartNo { get; set; } 

        public void Validate()
        {
            new EditUsrTrsRqstBankInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
