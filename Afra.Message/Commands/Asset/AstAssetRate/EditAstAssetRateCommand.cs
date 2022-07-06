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
    public class EditAstAssetRateCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstAssetRateId { get; set; }  
 
		public Int32 AARAstRef { get; set; }  
 
		public String AARType { get; set; }  
 
		public String AARDepType { get; set; }  
 
		public DateTime AARDate { get; set; }  
 
		public Nullable<Double> AARRatio { get; set; }  
 
		public Nullable<Int32> AstDocRatioRef { get; set; } 

        public void Validate()
        {
            new EditAstAssetRateCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
