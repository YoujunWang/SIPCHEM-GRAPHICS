using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_LUBE_OIL")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_LUBE_OIL
    { 
        public N_LUBE_OIL() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
