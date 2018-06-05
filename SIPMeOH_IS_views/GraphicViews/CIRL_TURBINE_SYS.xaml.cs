using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("CIRL_TURBINE_SYS")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class CIRL_TURBINE_SYS
    { 
        public CIRL_TURBINE_SYS() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
