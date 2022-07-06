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
    public class EditHrmBaseAmountsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmBaseAmountsId { get; set; }  
 
		public String HBAType { get; set; }  
 
		public Int32 HBABaseId { get; set; }  
 
		public DateTime HBADate { get; set; }  
 
		public Double HBAQty { get; set; } 

        public void Validate()
        {
            new EditHrmBaseAmountsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
