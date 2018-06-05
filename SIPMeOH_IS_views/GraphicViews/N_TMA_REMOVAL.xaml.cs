using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_TMA_REMOVAL")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_TMA_REMOVAL
    { 
        public N_TMA_REMOVAL() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
