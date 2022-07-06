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
    public class EditPayBdgValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayBdgValId { get; set; }  
 
		public Int32 PBVPersRef { get; set; }  
 
		public Int32 PBVElmntRef { get; set; }  
 
		public Int32 PBVIssueYear { get; set; }  
 
		public Int32 PBVIssueMonth { get; set; }  
 
		public Int32 PBVEffectYear { get; set; }  
 
		public Int32 PBVEffectMonth { get; set; }  
 
		public Nullable<Double> PBVAmount { get; set; }  
 
		public Nullable<Int32> PBVIYearMonth { get; set; }  
 
		public Nullable<Int32> PBVEYearMonth { get; set; } 

        public void Validate()
        {
            new EditPayBdgValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
