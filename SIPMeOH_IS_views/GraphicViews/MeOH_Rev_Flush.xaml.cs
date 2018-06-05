using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("MeOH_Rev_Flush")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class MeOH_Rev_Flush
    { 
        public MeOH_Rev_Flush() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
