using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrSysQuerys : BaseEntity
    {
          
 
		public Int32 GnrSysQryId { get; set; }  
 
		public String GSQTitle { get; set; }  
 
		public String GSQView { get; set; }  
 
		public String GSQSysRef { get; set; } 
    }
}


