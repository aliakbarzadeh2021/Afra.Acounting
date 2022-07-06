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
    public class AddGnrSysMsgCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrSysMsgId { get; set; }  
 
		public String GSMTitle { get; set; }  
 
		public String GSMDescr { get; set; }  
 
		public DateTime GSMSDate { get; set; }  
 
		public DateTime GSMEDate { get; set; }  
 
		public Nullable<Int32> GSMType { get; set; }  
 
		public Int32 GSMCreator { get; set; } 

        public void Validate()
        {
            new AddGnrSysMsgCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
