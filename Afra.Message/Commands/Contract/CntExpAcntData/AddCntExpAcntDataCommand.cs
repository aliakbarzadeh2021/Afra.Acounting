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
    public class AddCntExpAcntDataCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntExpAcntDataId { get; set; }  
 
		public Int32 CEADExpAcntRef { get; set; }  
 
		public Int32 CEADFldRef { get; set; }  
 
		public Nullable<Double> CEADAmount { get; set; } 

        public void Validate()
        {
            new AddCntExpAcntDataCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
