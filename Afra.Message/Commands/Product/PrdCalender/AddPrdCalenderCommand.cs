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
    public class AddPrdCalenderCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdCalenderId { get; set; }  
 
		public DateTime PCDate { get; set; }  
 
		public Int32 PCDayType { get; set; }  
 
		public DateTime PCPrdSTime { get; set; }  
 
		public DateTime PCPrdETime { get; set; } 

        public void Validate()
        {
            new AddPrdCalenderCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
