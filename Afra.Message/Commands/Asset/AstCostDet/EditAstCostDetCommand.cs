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
    public class EditAstCostDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstCostDetID { get; set; }  
 
		public Int32 ACDType { get; set; }  
 
		public Int32 ACDItmRef { get; set; }  
 
		public Nullable<Double> ACDInstall { get; set; }  
 
		public Nullable<Double> ACDOther { get; set; }  
 
		public Nullable<Double> ACDTax { get; set; }  
 
		public Nullable<Double> ACDDuty { get; set; } 

        public void Validate()
        {
            new EditAstCostDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
