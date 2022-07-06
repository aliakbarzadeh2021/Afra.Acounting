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
    public class EditHrmPersAccountCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmPersAcntId { get; set; }  
 
		public Int32 HPAPersRef { get; set; }  
 
		public Int32 HPABankRef { get; set; }  
 
		public DateTime HPADate { get; set; }  
 
		public Nullable<Int32> HPAElmntRef { get; set; }  
 
		public String HPANumber { get; set; }  
 
		public Nullable<Int32> HPASit { get; set; } 

        public void Validate()
        {
            new EditHrmPersAccountCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
