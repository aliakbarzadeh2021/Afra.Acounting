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
    public class AddAccSLCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String sl_Code { get; set; }  
 
		public String sl_Title { get; set; }  
 
		public String GlRef { get; set; }  
 
		public String sl_BalanceType { get; set; }  
 
		public Nullable<Int32> sl_HaveQty { get; set; }  
 
		public Nullable<Int32> sl_HaveCur { get; set; } 

        public void Validate()
        {
            new AddAccSLCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
