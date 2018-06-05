using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("DESATURATOR")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DESATURATOR
    { 
        public DESATURATOR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
