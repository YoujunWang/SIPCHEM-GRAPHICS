using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SG_SEAL_GAS_SYS")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SG_SEAL_GAS_SYS
    { 
        public SG_SEAL_GAS_SYS() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
