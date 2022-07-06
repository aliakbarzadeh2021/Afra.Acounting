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
    public class AddUsrContInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String ContNum { get; set; }  
 
		public String StDate { get; set; }  
 
		public String EnDate { get; set; }  
 
		public String Descr { get; set; } 

        public void Validate()
        {
            new AddUsrContInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
