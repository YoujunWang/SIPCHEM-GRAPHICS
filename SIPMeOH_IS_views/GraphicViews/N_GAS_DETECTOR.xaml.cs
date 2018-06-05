using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_GAS_DETECTOR")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_GAS_DETECTOR
    { 
        public N_GAS_DETECTOR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
