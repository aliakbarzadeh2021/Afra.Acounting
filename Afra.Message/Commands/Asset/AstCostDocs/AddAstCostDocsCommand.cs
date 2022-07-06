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
    public class AddAstCostDocsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstCstDocId { get; set; }  
 
		public String AsDCType { get; set; }  
 
		public DateTime AsDCDate { get; set; }  
 
		public Int32 AsDCNum { get; set; }  
 
		public Nullable<Int32> AsDCLocalNum { get; set; }  
 
		public String AsDCDescr { get; set; }  
 
		public Nullable<Int32> AsDCState { get; set; }  
 
		public Nullable<Int32> AsDCAccPrdRef { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; } 

        public void Validate()
        {
            new AddAstCostDocsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
