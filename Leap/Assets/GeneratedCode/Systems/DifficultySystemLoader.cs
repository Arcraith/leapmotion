// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LeapDB {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    
    
    [uFrame.Attributes.uFrameIdentifier("ddaf9895-53e8-422a-8808-cb0a6ae268e0")]
    public partial class DifficultySystemLoader : uFrame.Kernel.SystemLoader {
        
        public override void Load() {
            this.AddSystem<DifficultySystem>();
        }
    }
}
