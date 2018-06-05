using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SD_REF_FANS")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SD_REF_FANS
    { 
        public SD_REF_FANS() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
