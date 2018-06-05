using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("REFORMER_PROVING_SYS")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class REFORMER_PROVING_SYS
    { 
        public REFORMER_PROVING_SYS() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
