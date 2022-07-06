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
    public class AddPayValStatAmntCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PVSAStatRef { get; set; }  
 
		public Int32 PVSAElmntRef { get; set; }  
 
		public Nullable<Double> PVSAAmount { get; set; } 

        public void Validate()
        {
            new AddPayValStatAmntCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
