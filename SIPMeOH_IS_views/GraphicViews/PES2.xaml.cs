using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("PES2")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class PES2
    { 
        public PES2() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
