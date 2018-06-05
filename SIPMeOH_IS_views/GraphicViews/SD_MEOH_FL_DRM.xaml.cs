using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SD_MEOH_FL_DRM")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SD_MEOH_FL_DRM
    { 
        public SD_MEOH_FL_DRM() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
