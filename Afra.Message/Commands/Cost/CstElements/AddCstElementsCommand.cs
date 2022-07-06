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
    public class AddCstElementsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstElmntId { get; set; }  
 
		public String CESLRef { get; set; }  
 
		public Nullable<Int32> CEType { get; set; }  
 
		public Nullable<Double> CEFixPrc { get; set; }  
 
		public Nullable<Double> CEChngPrc { get; set; } 

        public void Validate()
        {
            new AddCstElementsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
