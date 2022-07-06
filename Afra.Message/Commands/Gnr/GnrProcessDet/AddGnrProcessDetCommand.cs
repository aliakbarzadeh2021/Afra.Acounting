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
    public class AddGnrProcessDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrProcessDetId { get; set; }  
 
		public Int32 GPDProccessRef { get; set; }  
 
		public String GPDTitle { get; set; }  
 
		public Int32 GPDStep { get; set; }  
 
		public Int32 GPDType { get; set; }  
 
		public Int32 GPDRefId { get; set; }  
 
		public String GPDRefData { get; set; }  
 
		public Nullable<Int32> GPDDecField { get; set; }  
 
		public Nullable<Int32> GPDRelStep { get; set; } 

        public void Validate()
        {
            new AddGnrProcessDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
