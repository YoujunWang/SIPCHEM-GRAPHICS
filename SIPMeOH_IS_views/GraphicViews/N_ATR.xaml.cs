using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_ATR")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_ATR
    { 
        public N_ATR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
