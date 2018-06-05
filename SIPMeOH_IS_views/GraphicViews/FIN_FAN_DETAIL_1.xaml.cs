using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("FIN_FAN_DETAIL_1")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class FIN_FAN_DETAIL_1
    { 
        public FIN_FAN_DETAIL_1() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
