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
    public class EditPrdOrdSchedCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdOrdSchedId { get; set; }  
 
		public Int32 POSItmRef { get; set; }  
 
		public Int32 POSPartRef { get; set; }  
 
		public Nullable<Int32> POSFrmlRef { get; set; }  
 
		public DateTime POSVDStart { get; set; }  
 
		public DateTime POSVTStart { get; set; }  
 
		public Nullable<Int32> POSState { get; set; }  
 
		public Nullable<Int32> POSPriority { get; set; }  
 
		public Nullable<Int32> POSMashRef { get; set; }  
 
		public Nullable<Int32> POSWStation { get; set; } 

        public void Validate()
        {
            new EditPrdOrdSchedCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
