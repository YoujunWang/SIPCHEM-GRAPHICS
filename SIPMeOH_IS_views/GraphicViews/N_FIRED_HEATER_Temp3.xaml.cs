using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_FIRED_HEATER_Temp3")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_FIRED_HEATER_Temp3
    { 
        public N_FIRED_HEATER_Temp3() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
