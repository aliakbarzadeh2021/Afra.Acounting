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
    public class EditCntContRatioCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntContRatioId { get; set; }  
 
		public Int32 CCRContRef { get; set; }  
 
		public DateTime CCRDate { get; set; }  
 
		public Double CCRRatio { get; set; } 

        public void Validate()
        {
            new EditCntContRatioCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
