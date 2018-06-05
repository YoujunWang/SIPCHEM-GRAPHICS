using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_ATR_ANALYZER")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_ATR_ANALYZER
    { 
        public N_ATR_ANALYZER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
