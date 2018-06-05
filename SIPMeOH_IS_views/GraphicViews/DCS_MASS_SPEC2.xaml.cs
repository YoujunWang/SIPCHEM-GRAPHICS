using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("DCS_MASS_SPEC2")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DCS_MASS_SPEC2
    { 
        public DCS_MASS_SPEC2() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
