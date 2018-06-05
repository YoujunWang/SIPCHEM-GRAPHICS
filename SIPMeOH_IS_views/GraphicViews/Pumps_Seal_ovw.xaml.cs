using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("Pumps_Seal_ovw")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Pumps_Seal_ovw
    { 
        public Pumps_Seal_ovw() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
