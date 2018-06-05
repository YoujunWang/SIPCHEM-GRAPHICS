using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("REACTOR_LOOP")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class REACTOR_LOOP
    { 
        public REACTOR_LOOP() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
