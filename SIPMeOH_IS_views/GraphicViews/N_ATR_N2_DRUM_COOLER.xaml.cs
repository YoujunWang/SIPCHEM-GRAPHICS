using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_ATR_N2_DRUM_COOLER")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_ATR_N2_DRUM_COOLER
    { 
        public N_ATR_N2_DRUM_COOLER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
