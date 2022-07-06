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
    public class AddTrsVchItmRelCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsVchItmRef { get; set; }  
 
		public String TVIRSysRef { get; set; }  
 
		public Int32 TVIRVchRef { get; set; }  
 
		public Nullable<Double> TVIRQty { get; set; }  
 
		public String TVIRDescr { get; set; } 

        public void Validate()
        {
            new AddTrsVchItmRelCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
