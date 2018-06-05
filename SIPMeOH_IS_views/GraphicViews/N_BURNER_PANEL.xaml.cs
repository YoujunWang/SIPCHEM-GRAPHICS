using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_BURNER_PANEL")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_BURNER_PANEL
    { 
        public N_BURNER_PANEL() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
