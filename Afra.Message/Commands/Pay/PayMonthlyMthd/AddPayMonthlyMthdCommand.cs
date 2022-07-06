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
    public class AddPayMonthlyMthdCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayMonthlyMthdId { get; set; }  
 
		public String PMMTitle { get; set; }  
 
		public Int32 PMMType { get; set; }  
 
		public String PMMVals { get; set; } 

        public void Validate()
        {
            new AddPayMonthlyMthdCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
