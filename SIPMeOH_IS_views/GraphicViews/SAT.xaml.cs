using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SAT")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SAT
    { 
        public SAT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
