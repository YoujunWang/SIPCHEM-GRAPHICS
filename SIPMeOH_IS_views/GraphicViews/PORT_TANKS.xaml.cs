using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("PORT_TANKS")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class PORT_TANKS
    { 
        public PORT_TANKS() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
