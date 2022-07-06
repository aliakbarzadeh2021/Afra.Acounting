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
    public class AddGnrDashboardsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrDashboardID { get; set; }  
 
		public String GDTitle { get; set; }  
 
		public String GDQuery { get; set; }  
 
		public String GDFillter { get; set; }  
 
		public String GDProp1 { get; set; }  
 
		public String GDProp2 { get; set; }  
 
		public String GDProp3 { get; set; }  
 
		public Byte[] GDLayout1 { get; set; }  
 
		public Byte[] GDLayout2 { get; set; }  
 
		public Byte[] GDLayout3 { get; set; }  
 
		public Byte[] GDLayout4 { get; set; } 

        public void Validate()
        {
            new AddGnrDashboardsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
