using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("TAT")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class TAT
    { 
        public TAT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
