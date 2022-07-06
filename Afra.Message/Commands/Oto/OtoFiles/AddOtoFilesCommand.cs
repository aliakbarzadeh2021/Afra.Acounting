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
    public class AddOtoFilesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoFilesId { get; set; }  
 
		public Nullable<Int32> OFParent { get; set; }  
 
		public String OFTitle { get; set; } 

        public void Validate()
        {
            new AddOtoFilesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
