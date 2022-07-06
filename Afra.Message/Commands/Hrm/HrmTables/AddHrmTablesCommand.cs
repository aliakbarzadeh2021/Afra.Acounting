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
    public class AddHrmTablesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmTablesId { get; set; }  
 
		public String HTTitle { get; set; }  
 
		public Int32 HTLevel { get; set; }  
 
		public Int32 HTKind { get; set; }  
 
		public String HTField1 { get; set; }  
 
		public String HTField2 { get; set; }  
 
		public String HTField3 { get; set; } 

        public void Validate()
        {
            new AddHrmTablesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
