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
    public class EditAstAssetSaleCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AASAstRef { get; set; }  
 
		public Nullable<Double> AASCost { get; set; }  
 
		public Nullable<Int32> AASAstCstRef { get; set; } 

        public void Validate()
        {
            new EditAstAssetSaleCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
