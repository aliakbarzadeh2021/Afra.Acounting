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
    public class EditBdgProjElmntCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgProjElmntId { get; set; }  
 
		public String BPETitle { get; set; }  
 
		public Int32 BPEGrp { get; set; }  
 
		public Int32 BPEParent { get; set; }  
 
		public Int32 BPEUnit { get; set; }  
 
		public Nullable<Int32> BPECurRef { get; set; }  
 
		public Nullable<Double> BPERate { get; set; }  
 
		public Int32 BPEPeriodId { get; set; }  
 
		public String BPESLRef { get; set; } 

        public void Validate()
        {
            new EditBdgProjElmntCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
