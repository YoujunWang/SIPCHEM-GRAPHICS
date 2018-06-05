using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_CO2_COMP")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_CO2_COMP
    { 
        public N_CO2_COMP() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
