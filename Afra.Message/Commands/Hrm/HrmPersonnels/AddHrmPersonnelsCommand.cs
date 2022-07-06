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
    public class AddHrmPersonnelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmPersID { get; set; }  
 
		public Int32 HPrsCrspndRef { get; set; }  
 
		public String HrmPersCode { get; set; }  
 
		public String HPrsFatherName { get; set; }  
 
		public String HPrsCertNo { get; set; }  
 
		public DateTime HPrsBirthDate { get; set; }  
 
		public Nullable<Int32> HPrsBirthLocRef { get; set; }  
 
		public String HPrsSex { get; set; }  
 
		public Nullable<Int32> HPrsIssuedIDLoc { get; set; }  
 
		public DateTime HPrsIssueDate { get; set; }  
 
		public String HPrsBloodGroup { get; set; }  
 
		public String HPrsCertSerial { get; set; }  
 
		public String HPrsNatCode { get; set; }  
 
		public Nullable<Int32> HPrsNat { get; set; }  
 
		public String HPrsWebPass { get; set; }  
 
		public Nullable<Int32> HPrsFmtRef { get; set; }  
 
		public Byte[] HPrsPic { get; set; }  
 
		public Byte[] HPrsSign { get; set; }  
 
		public Nullable<Int32> HPrsWebSit { get; set; } 

        public void Validate()
        {
            new AddHrmPersonnelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
