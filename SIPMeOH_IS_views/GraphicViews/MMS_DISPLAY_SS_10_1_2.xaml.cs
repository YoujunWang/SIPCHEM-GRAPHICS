using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("MMS_DISPLAY_SS_10_1_2")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class MMS_DISPLAY_SS_10_1_2
    { 
        public MMS_DISPLAY_SS_10_1_2() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
