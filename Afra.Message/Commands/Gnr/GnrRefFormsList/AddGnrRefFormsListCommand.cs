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
    public class AddGnrRefFormsListCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 RefVchId { get; set; }  
 
		public String RVTitle { get; set; }  
 
		public String RVHdrViewName { get; set; }  
 
		public String RVItmViewName { get; set; }  
 
		public String RVHdrIdField { get; set; }  
 
		public String RVItmIdField { get; set; }  
 
		public String RVLinkStr { get; set; }  
 
		public String RVTitleCol { get; set; }  
 
		public String RVSystem { get; set; }  
 
		public String RVBaseSys { get; set; } 

        public void Validate()
        {
            new AddGnrRefFormsListCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
