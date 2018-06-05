using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SG_PERMISIVES")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SG_PERMISIVES
    { 
        public SG_PERMISIVES() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
