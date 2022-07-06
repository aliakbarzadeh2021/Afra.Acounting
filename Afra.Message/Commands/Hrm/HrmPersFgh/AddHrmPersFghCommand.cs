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
    public class AddHrmPersFghCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PersFghId { get; set; }  
 
		public Nullable<Int32> PersFghPersRef { get; set; }  
 
		public DateTime PersFghDate { get; set; }  
 
		public String PersFghType { get; set; }  
 
		public Nullable<Int32> PersFghDay { get; set; }  
 
		public String PersFghDescr { get; set; } 

        public void Validate()
        {
            new AddHrmPersFghCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
