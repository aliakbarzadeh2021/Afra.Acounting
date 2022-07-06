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
    public class EditSleDebCreItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleDebCreItmId { get; set; }  
 
		public Nullable<Int32> SleDebCreHdrRef { get; set; }  
 
		public Nullable<Int32> SDCISeq { get; set; }  
 
		public Nullable<Int32> SDCIRole { get; set; }  
 
		public String SDCIDebSL { get; set; }  
 
		public String SDCIDebDL { get; set; }  
 
		public String SDCIDebDL5 { get; set; }  
 
		public String SDCIDebDL6 { get; set; }  
 
		public String SDCICreSL { get; set; }  
 
		public String SDCICreDL { get; set; }  
 
		public String SDCICreDL5 { get; set; }  
 
		public String SDCICreDL6 { get; set; }  
 
		public Nullable<Double> SDCIAmount { get; set; }  
 
		public String SDCIDescr { get; set; } 

        public void Validate()
        {
            new EditSleDebCreItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
