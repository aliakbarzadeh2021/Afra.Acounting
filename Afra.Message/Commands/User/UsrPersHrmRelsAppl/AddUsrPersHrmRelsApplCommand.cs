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
    public class AddUsrPersHrmRelsApplCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String Cause { get; set; }  
 
		public String LttrNo { get; set; }  
 
		public String LttrDate { get; set; }  
 
		public String Appler { get; set; }  
 
		public String Oprs { get; set; } 

        public void Validate()
        {
            new AddUsrPersHrmRelsApplCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
