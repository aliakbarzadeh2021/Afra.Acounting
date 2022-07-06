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
    public class AddOtoIndicatorCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoIndicatorId { get; set; }  
 
		public String OIDescr { get; set; }  
 
		public Int32 OIStartNo { get; set; }  
 
		public Int32 OISeed { get; set; }  
 
		public String OIPattern { get; set; }  
 
		public DateTime OIStartDate { get; set; }  
 
		public DateTime OIEndDate { get; set; } 

        public void Validate()
        {
            new AddOtoIndicatorCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
