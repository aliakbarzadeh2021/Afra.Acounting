using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrNumVchConfig : BaseEntity
    {
          
 
		public Int32 GnrNumVchConfigId { get; set; }  
 
		public String GNVCTitle { get; set; }  
 
		public String GNVCSysRef { get; set; }  
 
		public Int32 GNVCPrdRef { get; set; }  
 
		public Int32 GNVCStartNum { get; set; }  
 
		public Int32 GNVCIdent { get; set; }  
 
		public Int32 GNVCMethod { get; set; }  
 
		public String GNVCRelField { get; set; }  
 
		public Nullable<Int32> GNVCDateCtrl { get; set; } 
    }
}


