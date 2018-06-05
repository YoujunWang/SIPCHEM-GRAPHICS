using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("E1103_AND_CT1101")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class E1103_AND_CT1101
    { 
        public E1103_AND_CT1101() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
