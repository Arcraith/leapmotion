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
    using UnityEngine;
    
    
    public class ActiavateMenuEventHandler {
        
        public MenuButton Group;
        
        private LeapDB.ActivateMenu _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private bool BoolNode187 = true;
        
        private object ActionNode68_message = default( System.Object );
        
        private string StringNode69 = "Activate Megatron!!! beep boop";
        
        public LeapDB.ActivateMenu Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual void Execute() {
            // SetVariableNode
            Group.Button.selected = (System.Boolean)BoolNode187;
            ActionNode68_message = StringNode69;
            // ActionNode
            // Visit uFrame.Actions.DebugLibrary.LogMessage
            uFrame.Actions.DebugLibrary.LogMessage(ActionNode68_message);
        }
    }
}
