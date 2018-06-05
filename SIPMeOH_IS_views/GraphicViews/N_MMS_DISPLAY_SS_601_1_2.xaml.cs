using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_MMS_DISPLAY_SS_601_1_2")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_MMS_DISPLAY_SS_601_1_2
    { 
        public N_MMS_DISPLAY_SS_601_1_2() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
