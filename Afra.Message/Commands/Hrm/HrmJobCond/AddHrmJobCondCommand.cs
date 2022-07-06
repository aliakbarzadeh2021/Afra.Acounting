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
    public class AddHrmJobCondCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmJobCondId { get; set; }  
 
		public Int32 HJCJobRef { get; set; }  
 
		public DateTime HJCDate { get; set; }  
 
		public String HJCCondStr { get; set; }  
 
		public String HJCCondTitle { get; set; }  
 
		public String HJCCondSQL { get; set; } 

        public void Validate()
        {
            new AddHrmJobCondCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
