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
    public class EditPayGrpValStatAmntCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PGVSElmntRef { get; set; }  
 
		public Int32 PGVSStatRef { get; set; }  
 
		public Nullable<Double> PGVSAmount { get; set; }  
 
		public Nullable<Int32> PGVSSit { get; set; } 

        public void Validate()
        {
            new EditPayGrpValStatAmntCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
