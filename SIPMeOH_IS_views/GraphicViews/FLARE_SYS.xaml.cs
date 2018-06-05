using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("FLARE_SYS")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class FLARE_SYS
    { 
        public FLARE_SYS() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
