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
    public class EditCstAccDataCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CADPeriodRef { get; set; }  
 
		public String CADSLRef { get; set; }  
 
		public String CADDLRef { get; set; }  
 
		public String CADDLFive { get; set; }  
 
		public String CADDLSix { get; set; }  
 
		public Nullable<Double> CADDebit { get; set; }  
 
		public Nullable<Double> CADCredit { get; set; } 

        public void Validate()
        {
            new EditCstAccDataCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
