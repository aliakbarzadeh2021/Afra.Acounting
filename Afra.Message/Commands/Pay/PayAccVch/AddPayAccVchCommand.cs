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
    public class AddPayAccVchCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayAccVchId { get; set; }  
 
		public Nullable<Int32> PAVTypeRef { get; set; }  
 
		public Nullable<Int32> PAVYear { get; set; }  
 
		public Nullable<Int32> PAVMonth { get; set; }  
 
		public Nullable<Int32> PAVPrdRef { get; set; } 

        public void Validate()
        {
            new AddPayAccVchCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
