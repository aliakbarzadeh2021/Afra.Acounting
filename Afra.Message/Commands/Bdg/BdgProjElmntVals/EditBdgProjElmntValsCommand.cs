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
    public class EditBdgProjElmntValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgProjElmntValId { get; set; }  
 
		public Int32 BPEVElmntRef { get; set; }  
 
		public String BPEVDLRef { get; set; }  
 
		public String BPEVDescr { get; set; }  
 
		public Nullable<Double> BPEVMonth1 { get; set; }  
 
		public Nullable<Double> BPEVMonth2 { get; set; }  
 
		public Nullable<Double> BPEVMonth3 { get; set; }  
 
		public Nullable<Double> BPEVMonth4 { get; set; }  
 
		public Nullable<Double> BPEVMonth5 { get; set; }  
 
		public Nullable<Double> BPEVMonth6 { get; set; }  
 
		public Nullable<Double> BPEVMonth7 { get; set; }  
 
		public Nullable<Double> BPEVMonth8 { get; set; }  
 
		public Nullable<Double> BPEVMonth9 { get; set; }  
 
		public Nullable<Double> BPEVMonth10 { get; set; }  
 
		public Nullable<Double> BPEVMonth11 { get; set; }  
 
		public Nullable<Double> BPEVMonth12 { get; set; } 

        public void Validate()
        {
            new EditBdgProjElmntValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
