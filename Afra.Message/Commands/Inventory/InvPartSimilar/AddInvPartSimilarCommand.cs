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
    public class AddInvPartSimilarCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvPartSimilarId { get; set; }  
 
		public Int32 IPSMainPartRef { get; set; }  
 
		public Int32 IPSSimiPartRef { get; set; }  
 
		public Int32 IPSOrder { get; set; }  
 
		public Nullable<Double> IPSRatio { get; set; } 

        public void Validate()
        {
            new AddInvPartSimilarCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
