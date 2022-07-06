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
    public class AddBdgElmntValsDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BEVDParentRef { get; set; }  
 
		public Int32 PEVDMonth { get; set; }  
 
		public Nullable<Double> PEVDVal { get; set; }  
 
		public Int32 BEVDMonth { get; set; }  
 
		public Nullable<Double> BEVDVal { get; set; } 

        public void Validate()
        {
            new AddBdgElmntValsDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
