using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("REF_COMB_CONTROL")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class REF_COMB_CONTROL
    { 
        public REF_COMB_CONTROL() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
