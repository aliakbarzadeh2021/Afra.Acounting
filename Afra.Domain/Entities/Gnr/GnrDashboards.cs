using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrDashboards : BaseEntity
    {
          
 
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
    }
}


