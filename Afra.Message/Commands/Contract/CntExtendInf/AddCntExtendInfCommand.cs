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
    public class AddCntExtendInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntExtendInfId { get; set; }  
 
		public Int32 CEIBaseItm { get; set; }  
 
		public Int32 CEIBaseType { get; set; }  
 
		public DateTime CEIFromDate { get; set; }  
 
		public String CEIDur { get; set; }  
 
		public Nullable<Double> CEIAmnt { get; set; }  
 
		public String CEIExtType { get; set; } 

        public void Validate()
        {
            new AddCntExtendInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
