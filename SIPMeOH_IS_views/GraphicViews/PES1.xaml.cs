using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("PES1")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class PES1
    { 
        public PES1() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
