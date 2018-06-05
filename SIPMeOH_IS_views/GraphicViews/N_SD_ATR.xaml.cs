using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_SD_ATR")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_SD_ATR
    { 
        public N_SD_ATR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
