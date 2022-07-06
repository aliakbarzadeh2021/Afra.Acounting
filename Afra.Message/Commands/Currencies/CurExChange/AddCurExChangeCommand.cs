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
    public class AddCurExChangeCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CurExchangeId { get; set; }  
 
		public Int32 CExMainCurRef { get; set; }  
 
		public Int32 CExRelCurRef { get; set; }  
 
		public DateTime CExDate { get; set; }  
 
		public Double CExRate { get; set; } 

        public void Validate()
        {
            new AddCurExChangeCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
