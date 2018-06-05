using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SAT_DESAT_CIRCULN2")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SAT_DESAT_CIRCULN2
    { 
        public SAT_DESAT_CIRCULN2() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
