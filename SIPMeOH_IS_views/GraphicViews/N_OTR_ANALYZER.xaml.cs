using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_OTR_ANALYZER")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_OTR_ANALYZER
    { 
        public N_OTR_ANALYZER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
