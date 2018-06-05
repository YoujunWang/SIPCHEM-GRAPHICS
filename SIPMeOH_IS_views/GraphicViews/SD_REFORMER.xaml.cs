using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SD_REFORMER")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SD_REFORMER
    { 
        public SD_REFORMER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
