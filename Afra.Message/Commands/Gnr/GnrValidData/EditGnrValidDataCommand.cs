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
    public class EditGnrValidDataCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrValidDataId { get; set; }  
 
		public Int32 GVDUserRef { get; set; }  
 
		public String GVDSysRef { get; set; }  
 
		public Int32 GVDConfirmer { get; set; } 

        public void Validate()
        {
            new EditGnrValidDataCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
