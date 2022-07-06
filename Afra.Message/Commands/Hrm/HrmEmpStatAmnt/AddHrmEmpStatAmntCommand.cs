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
    public class AddHrmEmpStatAmntCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HSAStatueRef { get; set; }  
 
		public Int32 HSAElmntRef { get; set; }  
 
		public Nullable<Double> HSAAmount { get; set; }  
 
		public DateTime HSAEffDate { get; set; }  
 
		public Nullable<Int32> HSAMthd { get; set; } 

        public void Validate()
        {
            new AddHrmEmpStatAmntCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
