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
    public class EditQcsMensCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QcsMenId { get; set; }  
 
		public Int32 QMCrsRef { get; set; }  
 
		public Int32 QMDegreeRef { get; set; } 

        public void Validate()
        {
            new EditQcsMensCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
