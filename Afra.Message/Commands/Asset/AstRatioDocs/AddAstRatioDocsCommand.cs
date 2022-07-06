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
    public class AddAstRatioDocsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstRatioDocId { get; set; }  
 
		public String AsDRType { get; set; }  
 
		public DateTime AsDRDate { get; set; }  
 
		public Int32 AsDRNum { get; set; }  
 
		public Nullable<Int32> AsDRLocalNum { get; set; }  
 
		public String AsDRDepType { get; set; }  
 
		public Nullable<Double> AsDRRatio { get; set; }  
 
		public String AsDRDescr { get; set; }  
 
		public Nullable<Int32> AsDRState { get; set; }  
 
		public Nullable<Int32> AsDRAccPrdRef { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; } 

        public void Validate()
        {
            new AddAstRatioDocsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
