using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("BFW1")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class BFW1
    { 
        public BFW1() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
