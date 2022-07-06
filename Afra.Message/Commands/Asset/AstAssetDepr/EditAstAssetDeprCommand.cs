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
    public class EditAstAssetDeprCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstAssetDeprId { get; set; }  
 
		public Int32 AADAstRef { get; set; }  
 
		public String AADDeprType { get; set; }  
 
		public Int32 AADYear { get; set; }  
 
		public Int32 AADMonth { get; set; }  
 
		public Nullable<Int32> AADAstInfRef { get; set; }  
 
		public Double AADAmount { get; set; }  
 
		public Nullable<Double> AADCstAmount { get; set; }  
 
		public Nullable<Int32> AADAccPrdRef { get; set; }  
 
		public Nullable<Int32> AADDeprVchRef { get; set; } 

        public void Validate()
        {
            new EditAstAssetDeprCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
