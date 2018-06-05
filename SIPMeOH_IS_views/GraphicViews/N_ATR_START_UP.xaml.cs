using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_ATR_START_UP")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_ATR_START_UP
    { 
        public N_ATR_START_UP() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
