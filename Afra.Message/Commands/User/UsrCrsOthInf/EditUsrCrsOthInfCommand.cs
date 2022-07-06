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
    public class EditUsrCrsOthInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String PersCode { get; set; }  
 
		public String WorkLoc { get; set; }  
 
		public String ContType { get; set; }  
 
		public String AcntNo { get; set; }  
 
		public Nullable<Int32> BaygNo { get; set; } 

        public void Validate()
        {
            new EditUsrCrsOthInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
