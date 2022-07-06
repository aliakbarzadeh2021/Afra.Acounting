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
    public class AddPayGrpValStatCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayGrpValStatId { get; set; }  
 
		public Nullable<Int32> PGVSNum { get; set; }  
 
		public DateTime PGVSIssueDate { get; set; }  
 
		public DateTime PGVSEffectDate { get; set; }  
 
		public String PGVSDescr { get; set; } 

        public void Validate()
        {
            new AddPayGrpValStatCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
