using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("PR00PID000")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class PR00PID000
    { 
        public PR00PID000() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
