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
    public class AddTrsFundsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFundId { get; set; }  
 
		public String TFTitle { get; set; }  
 
		public Nullable<Int32> TFCrsRef { get; set; }  
 
		public DateTime TFOpenDate { get; set; }  
 
		public Double TFBeginAmnt { get; set; }  
 
		public Nullable<Double> TFMaxAmnt { get; set; }  
 
		public String TFSLRef { get; set; }  
 
		public String TFDLRef { get; set; }  
 
		public String TFDLFive { get; set; }  
 
		public String TFDLSix { get; set; } 

        public void Validate()
        {
            new AddTrsFundsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
