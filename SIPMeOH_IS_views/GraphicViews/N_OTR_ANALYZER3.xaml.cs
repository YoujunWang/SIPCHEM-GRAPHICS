using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_OTR_ANALYZER3")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_OTR_ANALYZER3
    { 
        public N_OTR_ANALYZER3() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
