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
    public class EditAstTransDocsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstTrnDocId { get; set; }  
 
		public String AsDTType { get; set; }  
 
		public DateTime AsDTDate { get; set; }  
 
		public Int32 AsDTNum { get; set; }  
 
		public Nullable<Int32> AsDTLocalNum { get; set; }  
 
		public Nullable<Int32> AsDTGrpRef { get; set; }  
 
		public Nullable<Int32> AsDTPitchRef { get; set; }  
 
		public Nullable<Int32> AsDTMenRef { get; set; }  
 
		public Nullable<Int32> AsDTCostCenter { get; set; }  
 
		public Nullable<Int32> AsDTAccPrdRef { get; set; }  
 
		public String AsDTDescr { get; set; }  
 
		public Nullable<Int32> AsDTState { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; } 

        public void Validate()
        {
            new EditAstTransDocsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
