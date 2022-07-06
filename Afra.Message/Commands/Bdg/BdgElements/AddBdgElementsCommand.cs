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
    public class AddBdgElementsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgElmntId { get; set; }  
 
		public String BESLRef { get; set; }  
 
		public Int32 BERole { get; set; }  
 
		public Int32 BEType { get; set; }  
 
		public Nullable<Int32> BEWarPoint { get; set; }  
 
		public Nullable<Int32> BEWarNotOk { get; set; } 

        public void Validate()
        {
            new AddBdgElementsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
