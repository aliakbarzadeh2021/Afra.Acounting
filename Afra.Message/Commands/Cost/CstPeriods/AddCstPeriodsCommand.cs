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
    public class AddCstPeriodsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstPeriodId { get; set; }  
 
		public String CPTitle { get; set; }  
 
		public DateTime CPFromDate { get; set; }  
 
		public DateTime CPToDate { get; set; }  
 
		public Nullable<Int32> CPState { get; set; }  
 
		public Nullable<Int32> CPWrkDay { get; set; } 

        public void Validate()
        {
            new AddCstPeriodsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
