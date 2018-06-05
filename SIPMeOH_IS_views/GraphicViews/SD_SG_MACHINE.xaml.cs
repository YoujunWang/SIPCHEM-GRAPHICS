using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SD_SG_MACHINE")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SD_SG_MACHINE
    { 
        public SD_SG_MACHINE() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
