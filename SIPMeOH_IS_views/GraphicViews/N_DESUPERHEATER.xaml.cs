using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_DESUPERHEATER")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_DESUPERHEATER
    { 
        public N_DESUPERHEATER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
