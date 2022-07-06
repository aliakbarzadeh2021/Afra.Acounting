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
    public class AddSleBrokerSalaryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleBrokerSalaryId { get; set; }  
 
		public String SBSTitle { get; set; }  
 
		public DateTime SBSFDate { get; set; }  
 
		public DateTime SBSTDate { get; set; }  
 
		public Int32 SBSBaseMthd { get; set; }  
 
		public Int32 SBSOprType { get; set; } 

        public void Validate()
        {
            new AddSleBrokerSalaryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
