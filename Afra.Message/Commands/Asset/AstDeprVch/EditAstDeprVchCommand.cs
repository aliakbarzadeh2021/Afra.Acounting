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
    public class EditAstDeprVchCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstDeprVchId { get; set; }  
 
		public Nullable<Int32> ADVFromMonth { get; set; }  
 
		public Nullable<Int32> ADVToMonth { get; set; }  
 
		public Nullable<Int32> ADVYear { get; set; }  
 
		public String ADVDescr { get; set; }  
 
		public Nullable<Int32> ADVPrdRef { get; set; } 

        public void Validate()
        {
            new EditAstDeprVchCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
