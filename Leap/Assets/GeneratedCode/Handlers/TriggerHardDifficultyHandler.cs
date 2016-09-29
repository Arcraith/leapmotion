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
    
    
    public class TriggerHardDifficultyHandler {
        
        public HardButton Collider;
        
        public IndexFingerComponent Source;
        
        private uFrame.ECS.OnTriggerEnterDispatcher _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private bool ActionNode151_value = default( System.Boolean );
        
        private UnityEngine.GameObject ActionNode152_obj = default( UnityEngine.GameObject );
        
        private string ActionNode152_color = default( System.String );
        
        private string StringNode153 = "white";
        
        private bool BoolNode155 = false;
        
        private LeapDB.DeselectMenuButtons PublishEventNode269_Result = default( LeapDB.DeselectMenuButtons );
        
        private UnityEngine.GameObject ActionNode122_obj = default( UnityEngine.GameObject );
        
        private string ActionNode122_color = default( System.String );
        
        private string StringNode123 = "red";
        
        private bool BoolNode157 = true;
        
        private LeapDB.HardDifficulty PublishEventNode40_Result = default( LeapDB.HardDifficulty );
        
        public uFrame.ECS.OnTriggerEnterDispatcher Event {
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
            ActionNode151_value = Collider.Button.selected;
            // ActionNode
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode151_value, ActionNode151_yes, ActionNode151_no);
        }
        
        private void ActionNode151_yes() {
            ActionNode152_obj = Collider.Button.gameObject;
            ActionNode152_color = StringNode153;
            // ActionNode
            // Visit GameObjectUtils.setColor
            GameObjectUtils.setColor(ActionNode152_obj, ActionNode152_color);
            // SetVariableNode
            Collider.Button.selected = (System.Boolean)BoolNode155;
        }
        
        private void ActionNode151_no() {
            // PublishEventNode
            var PublishEventNode269_Event = new DeselectMenuButtons();
            System.Publish(PublishEventNode269_Event);
            PublishEventNode269_Result = PublishEventNode269_Event;
            ActionNode122_obj = Collider.Button.gameObject;
            ActionNode122_color = StringNode123;
            // ActionNode
            // Visit GameObjectUtils.setColor
            GameObjectUtils.setColor(ActionNode122_obj, ActionNode122_color);
            // SetVariableNode
            Collider.Button.selected = (System.Boolean)BoolNode157;
            // PublishEventNode
            var PublishEventNode40_Event = new HardDifficulty();
            System.Publish(PublishEventNode40_Event);
            PublishEventNode40_Result = PublishEventNode40_Event;
        }
    }
}