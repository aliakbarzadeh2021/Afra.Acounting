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
    public class EditHrmJobsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 JobId { get; set; }  
 
		public String JobCode { get; set; }  
 
		public String JobTitle { get; set; }  
 
		public Nullable<Int32> JPayGrpRef { get; set; }  
 
		public String JHardJobCode { get; set; }  
 
		public Nullable<Double> JobPoint { get; set; }  
 
		public Nullable<Int32> JobOthCode { get; set; } 

        public void Validate()
        {
            new EditHrmJobsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
