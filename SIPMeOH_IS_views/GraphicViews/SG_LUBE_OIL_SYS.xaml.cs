using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SG_LUBE_OIL_SYS")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SG_LUBE_OIL_SYS
    { 
        public SG_LUBE_OIL_SYS() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
