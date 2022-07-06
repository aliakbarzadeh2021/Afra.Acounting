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
    public class AddPayCalcBaseCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayCalcBaseId { get; set; }  
 
		public Nullable<Int32> PCBType { get; set; }  
 
		public Nullable<Int32> PCBPersRef { get; set; }  
 
		public Nullable<Int32> PCBElmntRef { get; set; }  
 
		public Nullable<Int32> PCBYearNum { get; set; }  
 
		public Nullable<Int32> PCBMonthNum { get; set; }  
 
		public Nullable<Int32> PCBVal { get; set; }  
 
		public Nullable<Int32> PCBYearMonth { get; set; } 

        public void Validate()
        {
            new AddPayCalcBaseCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
