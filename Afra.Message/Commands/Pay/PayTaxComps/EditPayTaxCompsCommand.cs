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
    public class EditPayTaxCompsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayTaxCompId { get; set; }  
 
		public Nullable<Int32> PTCCompRef { get; set; }  
 
		public Nullable<Int32> PTCCompType { get; set; }  
 
		public Nullable<Int32> PTCCompKind { get; set; }  
 
		public String PTCBrnName { get; set; }  
 
		public String PTCPhone { get; set; }  
 
		public String PTCCode { get; set; }  
 
		public String PTCBrId { get; set; }  
 
		public String PTCFName1 { get; set; }  
 
		public String PTCLName1 { get; set; }  
 
		public String PTCNatCode1 { get; set; }  
 
		public String PTCPost1 { get; set; }  
 
		public String PTCFName2 { get; set; }  
 
		public String PTCLName2 { get; set; }  
 
		public String PTCNatCode2 { get; set; }  
 
		public String PTCPost2 { get; set; } 

        public void Validate()
        {
            new EditPayTaxCompsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
