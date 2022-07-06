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
    public class EditBdgFinalRepCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgFinalRepId { get; set; }  
 
		public Int32 BFRPeriodRef { get; set; }  
 
		public Int32 BFRItmId { get; set; }  
 
		public Int32 BFRType { get; set; }  
 
		public Nullable<Int32> BFRTopicRef { get; set; }  
 
		public String BFRSLCode { get; set; }  
 
		public String BFRDL4 { get; set; }  
 
		public String BFRDL5 { get; set; }  
 
		public String BFRDL6 { get; set; }  
 
		public String BFRDL7 { get; set; }  
 
		public String BFRCurTitle { get; set; }  
 
		public Nullable<Int32> BFRMonthId { get; set; }  
 
		public Nullable<Double> BFRBdgValue { get; set; }  
 
		public Nullable<Double> BFRWorkValue { get; set; }  
 
		public Nullable<Double> BFRRBdgValue { get; set; }  
 
		public Nullable<Double> BFRRWorkValue { get; set; } 

        public void Validate()
        {
            new EditBdgFinalRepCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
