using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_RESET_LIST1")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_RESET_LIST1
    { 
        public N_RESET_LIST1() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
