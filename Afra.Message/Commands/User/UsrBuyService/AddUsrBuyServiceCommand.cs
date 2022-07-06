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
    public class AddUsrBuyServiceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String DocNo { get; set; }  
 
		public String DocDate { get; set; }  
 
		public Nullable<Int32> DLRef { get; set; }  
 
		public String HDescr { get; set; } 

        public void Validate()
        {
            new AddUsrBuyServiceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
