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
    public class EditGeoPosCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GeoPosId { get; set; }  
 
		public Nullable<Int32> GeoPostParent { get; set; }  
 
		public String GeoPostTitle { get; set; } 

        public void Validate()
        {
            new EditGeoPosCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
