using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("Methanol_DCS")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Methanol_DCS
    { 
        public Methanol_DCS() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
