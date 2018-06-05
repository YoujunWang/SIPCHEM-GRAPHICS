using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("FG_LUBE_OIL_SG")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class FG_LUBE_OIL_SG
    { 
        public FG_LUBE_OIL_SG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
