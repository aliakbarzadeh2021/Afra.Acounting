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
    public class EditPrdVchItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdVchItmId { get; set; }  
 
		public Nullable<Int32> PrdVchHdrRef { get; set; }  
 
		public Nullable<Int32> PVISeq { get; set; }  
 
		public Nullable<Int32> PVICostCenterRef { get; set; }  
 
		public Int32 PVIPartRef { get; set; }  
 
		public Nullable<Int32> PVIUnitRef { get; set; }  
 
		public Nullable<Int32> PVIFormulRef { get; set; }  
 
		public Double PVIQty { get; set; }  
 
		public String PVIDescr { get; set; } 

        public void Validate()
        {
            new EditPrdVchItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
