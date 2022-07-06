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
    public class EditSleCtgryAccCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SCACtgryRef { get; set; }  
 
		public Int32 SCAVchType { get; set; }  
 
		public String SCASLRef { get; set; }  
 
		public Nullable<Int32> SCADL4Type { get; set; }  
 
		public Nullable<Int32> SCADL5Type { get; set; }  
 
		public Nullable<Int32> SCADL6Type { get; set; } 

        public void Validate()
        {
            new EditSleCtgryAccCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
