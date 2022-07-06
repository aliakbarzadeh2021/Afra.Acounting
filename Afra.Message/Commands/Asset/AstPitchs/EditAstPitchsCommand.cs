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
    public class EditAstPitchsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstPitchId { get; set; }  
 
		public Nullable<Int32> AstPitchParent { get; set; }  
 
		public String AstPitchCode { get; set; }  
 
		public String AstPitchTitle { get; set; }  
 
		public Nullable<Int32> APMainRoot { get; set; } 

        public void Validate()
        {
            new EditAstPitchsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
