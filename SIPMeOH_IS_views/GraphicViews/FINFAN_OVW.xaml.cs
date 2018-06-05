using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("FINFAN_OVW")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class FINFAN_OVW
    { 
        public FINFAN_OVW() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
