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
    public class EditTrsFacTypeInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFacTypeInfId { get; set; }  
 
		public Int32 TFTIFacRef { get; set; }  
 
		public DateTime TFTIDate { get; set; }  
 
		public Double TFTIRate { get; set; }  
 
		public Int32 TFTIDur { get; set; } 

        public void Validate()
        {
            new EditTrsFacTypeInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
