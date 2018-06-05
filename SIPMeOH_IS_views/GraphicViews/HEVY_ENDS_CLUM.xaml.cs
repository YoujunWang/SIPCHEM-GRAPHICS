using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("HEVY_ENDS_CLUM")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class HEVY_ENDS_CLUM
    { 
        public HEVY_ENDS_CLUM() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
