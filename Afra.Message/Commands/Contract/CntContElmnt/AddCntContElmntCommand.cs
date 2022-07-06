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
    public class AddCntContElmntCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntContElmntId { get; set; }  
 
		public Int32 CCEContRef { get; set; }  
 
		public Int32 CCEFldRef { get; set; }  
 
		public Nullable<Double> CCEAmount { get; set; } 

        public void Validate()
        {
            new AddCntContElmntCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
