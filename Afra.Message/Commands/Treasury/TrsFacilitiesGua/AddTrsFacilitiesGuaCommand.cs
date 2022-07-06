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
    public class AddTrsFacilitiesGuaCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFacilitiesGuaId { get; set; }  
 
		public Int32 TFGFacRef { get; set; }  
 
		public Nullable<Int32> TFGRcvDocId { get; set; }  
 
		public String TFGDescr { get; set; } 

        public void Validate()
        {
            new AddTrsFacilitiesGuaCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
