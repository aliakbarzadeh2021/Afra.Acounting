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
    public class AddCntAcquitInfsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntAcquitInfId { get; set; }  
 
		public Int32 CAIContRef { get; set; }  
 
		public String CAIType { get; set; }  
 
		public DateTime CAIDate { get; set; } 

        public void Validate()
        {
            new AddCntAcquitInfsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
