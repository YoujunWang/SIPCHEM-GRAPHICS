using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_OTR_WATER")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_OTR_WATER
    { 
        public N_OTR_WATER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
