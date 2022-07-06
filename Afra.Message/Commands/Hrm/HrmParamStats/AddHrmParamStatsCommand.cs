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
    public class AddHrmParamStatsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmParamStatId { get; set; }  
 
		public Int32 HPSPersRef { get; set; }  
 
		public DateTime HPSIssueDate { get; set; }  
 
		public DateTime HPSEffectDate { get; set; }  
 
		public String HPSDescr { get; set; }  
 
		public Nullable<Int32> HPSGrpStatRef { get; set; }  
 
		public String HPSIYrMonth { get; set; }  
 
		public String HPSEYrMonth { get; set; }  
 
		public Nullable<DateTime> HPSLastChange { get; set; }  
 
		public Nullable<Int32> HPSCreator { get; set; }  
 
		public Nullable<Int32> HPSSit { get; set; } 

        public void Validate()
        {
            new AddHrmParamStatsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
