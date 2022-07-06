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
    public class AddPayVchDetInfsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayVchDetId { get; set; }  
 
		public Int32 PayVchDetRef { get; set; }  
 
		public Nullable<Int32> PVDEmpRef { get; set; }  
 
		public Nullable<Int32> PVDCostCntrRef { get; set; } 

        public void Validate()
        {
            new AddPayVchDetInfsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
