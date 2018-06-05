using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("Sys_PSTEMP_Alarms")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Sys_PSTEMP_Alarms
    { 
        public Sys_PSTEMP_Alarms() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
