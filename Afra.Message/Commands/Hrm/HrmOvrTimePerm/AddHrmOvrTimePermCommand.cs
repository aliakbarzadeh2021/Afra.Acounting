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
    public class AddHrmOvrTimePermCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmOvrTimePermId { get; set; }  
 
		public Nullable<Int32> HOvPPersRef { get; set; }  
 
		public Nullable<Int32> HOvPNum { get; set; }  
 
		public DateTime HOvPDate { get; set; }  
 
		public DateTime HOvPFromDate { get; set; }  
 
		public DateTime HOvPFromTime { get; set; }  
 
		public DateTime HOvPToDate { get; set; }  
 
		public DateTime HOvPToTime { get; set; } 

        public void Validate()
        {
            new AddHrmOvrTimePermCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
