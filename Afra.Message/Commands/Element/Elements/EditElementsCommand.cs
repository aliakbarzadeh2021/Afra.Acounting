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
    public class EditElementsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ElmntId { get; set; }  
 
		public String ElmntTitle { get; set; }  
 
		public String ElmntType { get; set; }  
 
		public Int32 ElmntRole { get; set; }  
 
		public Nullable<Int32> ElmntFishPr { get; set; }  
 
		public Nullable<Int32> ElmntCalcPr { get; set; }  
 
		public Nullable<Int32> ElmntCompRef { get; set; }  
 
		public Nullable<Int32> ElmntStatPr { get; set; }  
 
		public Nullable<Int32> ElmntPayListPr { get; set; } 

        public void Validate()
        {
            new EditElementsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
