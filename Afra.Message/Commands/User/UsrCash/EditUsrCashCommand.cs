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
    public class EditUsrCashCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public Nullable<Int32> VNo { get; set; }  
 
		public String VDate { get; set; }  
 
		public String Descr { get; set; } 

        public void Validate()
        {
            new EditUsrCashCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
