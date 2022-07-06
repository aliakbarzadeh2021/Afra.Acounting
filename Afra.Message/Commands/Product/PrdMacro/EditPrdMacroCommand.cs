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
    public class EditPrdMacroCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PMProdRef { get; set; }  
 
		public DateTime PMSDate { get; set; }  
 
		public DateTime PMEDate { get; set; }  
 
		public String PMDur { get; set; }  
 
		public Double PMQty { get; set; }  
 
		public Int32 PMYear { get; set; } 

        public void Validate()
        {
            new EditPrdMacroCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
