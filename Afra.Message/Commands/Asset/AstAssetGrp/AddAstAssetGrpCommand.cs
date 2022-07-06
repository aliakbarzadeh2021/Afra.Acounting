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
    public class AddAstAssetGrpCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstAssetGrpId { get; set; }  
 
		public Nullable<Int32> AAGParent { get; set; }  
 
		public String AAGCode { get; set; }  
 
		public String AAGTitle { get; set; }  
 
		public Nullable<Int32> AstCtgryRef { get; set; }  
 
		public String AAGMethod { get; set; }  
 
		public Nullable<Double> AAGRatio { get; set; }  
 
		public Nullable<Int32> AAGMainRoot { get; set; }  
 
		public String AAGSLRef { get; set; }  
 
		public Nullable<Int32> AAGDL4Type { get; set; }  
 
		public String AAGDL4Code { get; set; }  
 
		public Nullable<Int32> AAGDL5Type { get; set; }  
 
		public String AAGDL5Code { get; set; }  
 
		public Nullable<Int32> AAGDL6Type { get; set; }  
 
		public String AAGDL6Code { get; set; }  
 
		public String AAGAccumDeprSLRef { get; set; }  
 
		public Nullable<Int32> AAGAccumDeprDL4Type { get; set; }  
 
		public String AAGAccumDeprDL4Code { get; set; }  
 
		public Nullable<Int32> AAGAccumDeprDL5Type { get; set; }  
 
		public String AAGAccumDeprDL5Code { get; set; }  
 
		public Nullable<Int32> AAGAccumDeprDL6Type { get; set; }  
 
		public String AAGAccumDeprDL6Code { get; set; }  
 
		public String AAGDeprSLRef { get; set; }  
 
		public Nullable<Int32> AAGDeprDL4Type { get; set; }  
 
		public String AAGDeprDL4Code { get; set; }  
 
		public Nullable<Int32> AAGDeprDL5Type { get; set; }  
 
		public String AAGDeprDL5Code { get; set; }  
 
		public Nullable<Int32> AAGDeprDL6Type { get; set; }  
 
		public String AAGDeprDL6Code { get; set; }  
 
		public String AAGCstSLRef { get; set; }  
 
		public Nullable<Int32> AAGCstDL4Type { get; set; }  
 
		public String AAGCstDL4Code { get; set; }  
 
		public Nullable<Int32> AAGCstDL5Type { get; set; }  
 
		public String AAGCstDL5Code { get; set; }  
 
		public Nullable<Int32> AAGCstDL6Type { get; set; }  
 
		public String AAGCstDL6Code { get; set; } 

        public void Validate()
        {
            new AddAstAssetGrpCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
