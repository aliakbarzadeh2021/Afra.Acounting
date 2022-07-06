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
    public class AddLookupsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String LkpId { get; set; }  
 
		public String LkpType { get; set; }  
 
		public String LkpTitle { get; set; }  
 
		public Nullable<Int32> LkpOrder { get; set; } 

        public void Validate()
        {
            new AddLookupsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
