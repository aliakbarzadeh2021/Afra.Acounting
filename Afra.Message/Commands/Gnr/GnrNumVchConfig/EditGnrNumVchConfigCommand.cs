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
    public class EditGnrNumVchConfigCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrNumVchConfigId { get; set; }  
 
		public String GNVCTitle { get; set; }  
 
		public String GNVCSysRef { get; set; }  
 
		public Int32 GNVCPrdRef { get; set; }  
 
		public Int32 GNVCStartNum { get; set; }  
 
		public Int32 GNVCIdent { get; set; }  
 
		public Int32 GNVCMethod { get; set; }  
 
		public String GNVCRelField { get; set; }  
 
		public Nullable<Int32> GNVCDateCtrl { get; set; } 

        public void Validate()
        {
            new EditGnrNumVchConfigCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
