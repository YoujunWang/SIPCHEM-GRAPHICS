using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_ATR_STEAM_DRUM")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_ATR_STEAM_DRUM
    { 
        public N_ATR_STEAM_DRUM() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
