using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("REF_BOILER_HTR")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class REF_BOILER_HTR
    { 
        public REF_BOILER_HTR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
