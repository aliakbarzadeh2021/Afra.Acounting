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
    public class AddUsrPersHrmRelsDocCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String TestDate { get; set; }  
 
		public String Result { get; set; }  
 
		public String NextDate { get; set; }  
 
		public String City { get; set; }  
 
		public String JobType { get; set; }  
 
		public String Descr { get; set; } 

        public void Validate()
        {
            new AddUsrPersHrmRelsDocCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
