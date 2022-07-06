using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrUserField : BaseEntity
    {
          
 
		public Int32 GnrUserFieldId { get; set; }  
 
		public Int32 GUFdFormRef { get; set; }  
 
		public Nullable<Int32> GUFdGroupRef { get; set; }  
 
		public String GUFdTitle { get; set; }  
 
		public String GUFdName { get; set; }  
 
		public Int32 GUFdType { get; set; }  
 
		public Nullable<Int32> GUFdShDir { get; set; }  
 
		public Nullable<Int32> GUFdShPrv { get; set; }  
 
		public Nullable<Int32> GUFdSize { get; set; }  
 
		public Nullable<Int32> GUFdShInList { get; set; }  
 
		public Nullable<Int32> GUFdForce { get; set; }  
 
		public Nullable<Int32> GUFdEditAble { get; set; }  
 
		public Nullable<Int32> GUFdIsCalcField { get; set; }  
 
		public String GUFdValids { get; set; }  
 
		public Nullable<Int32> GUFdRefrence { get; set; }  
 
		public Nullable<Int32> GUOrder { get; set; }  
 
		public String GUFdCalcStr { get; set; } 
    }
}


