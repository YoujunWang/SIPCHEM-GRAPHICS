using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("BFW2")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class BFW2
    { 
        public BFW2() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
