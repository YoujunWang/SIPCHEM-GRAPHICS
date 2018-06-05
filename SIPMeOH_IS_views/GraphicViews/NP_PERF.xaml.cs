using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("NP_PERF")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class NP_PERF
    { 
        public NP_PERF() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
