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
    public class EditGnrUserMsgCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrUserMsgId { get; set; }  
 
		public Int32 GUMFromUser { get; set; }  
 
		public Int32 GUMToUser { get; set; }  
 
		public String GUMMsg { get; set; }  
 
		public Nullable<Int32> GUMSit { get; set; }  
 
		public Nullable<Int32> GUMAlarmRef { get; set; }  
 
		public DateTime GUMDate { get; set; } 

        public void Validate()
        {
            new EditGnrUserMsgCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
