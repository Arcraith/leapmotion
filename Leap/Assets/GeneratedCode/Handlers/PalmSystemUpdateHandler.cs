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
    using Leap;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class PalmSystemUpdateHandler {
        
        public MenuButton Group;
        
        private uFrame.ECS.ISystemUpdate _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private Leap.Frame ActionNode5_Result = default( Leap.Frame );
        
        private Leap.Frame ActionNode6_frame = default( Leap.Frame );
        
        private Leap.Hand ActionNode6_left = default( Leap.Hand );
        
        private object ActionNode7_toCheck = default( System.Object );
        
        private object ActionNode8_key = default( System.Object );
        
        private string StringNode9 = "AllExt";
        
        private Leap.Hand ActionNode8_hand = default( Leap.Hand );
        
        private bool BoolNode167 = true;
        
        private bool BoolNode215 = false;
        
        private Leap.Hand ActionNode12_hand = default( Leap.Hand );
        
        private Leap.Vector ActionNode12_Result = default( Leap.Vector );
        
        private float ActionNode13_a = default( System.Single );
        
        private float ActionNode13_b = default( System.Single );
        
        private float FloatNode14 = -0.8F;
        
        private bool ActionNode13_Result = default( System.Boolean );
        
        private bool ActionNode196_first = default( System.Boolean );
        
        private bool ActionNode196_second = default( System.Boolean );
        
        private UnityEngine.GameObject ActionNode24_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode24_state = default( System.Boolean );
        
        private bool BoolNode25 = true;
        
        private UnityEngine.GameObject ActionNode22_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode22_state = default( System.Boolean );
        
        private bool BoolNode23 = false;
        
        public uFrame.ECS.ISystemUpdate Event {
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
            // ActionNode
            // Visit FrameUtils.getFrame
            ActionNode5_Result = FrameUtils.getFrame();
            ActionNode6_frame = ActionNode5_Result;
            // ActionNode
            // Visit FrameUtils.getLeftHandFromFrame
            FrameUtils.getLeftHandFromFrame(ActionNode6_frame, out ActionNode6_left);
            ActionNode7_toCheck = ActionNode6_left;
            // ActionNode
            // Visit ConditionsUtils.isNull
            ConditionsUtils.isNull(ActionNode7_toCheck, ActionNode7_yes, ActionNode7_no);
        }
        
        private void ActionNode7_yes() {
        }
        
        private void ActionNode8_yes() {
            // SetVariableNode
            Group.MainButton.handStretched = (System.Boolean)BoolNode167;
        }
        
        private void ActionNode8_no() {
            // SetVariableNode
            Group.MainButton.handStretched = (System.Boolean)BoolNode215;
        }
        
        private void ActionNode13_yes() {
        }
        
        private void ActionNode13_no() {
        }
        
        private void ActionNode196_yes() {
            ActionNode24_obj = Group.MainButton.gameObject;
            ActionNode24_state = BoolNode25;
            // ActionNode
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode24_obj, ActionNode24_state);
            // SetVariableNode
            Group.Button.active = (System.Boolean)BoolNode25;
        }
        
        private void ActionNode196_no() {
            ActionNode22_obj = Group.MainButton.gameObject;
            ActionNode22_state = BoolNode23;
            // ActionNode
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode22_obj, ActionNode22_state);
            // SetVariableNode
            Group.Button.active = (System.Boolean)BoolNode23;
        }
        
        private void ActionNode7_no() {
            ActionNode8_key = StringNode9;
            ActionNode8_hand = ActionNode6_left;
            // ActionNode
            // Visit GestureUtils.isGestureSatisified
            GestureUtils.isGestureSatisified(ActionNode8_key, ActionNode8_hand, ActionNode8_yes, ActionNode8_no);
            ActionNode12_hand = ActionNode6_left;
            // ActionNode
            // Visit HandUtils.getPalmNormal
            ActionNode12_Result = HandUtils.getPalmNormal(ActionNode12_hand);
            ActionNode13_a = ActionNode12_Result.y;
            ActionNode13_b = FloatNode14;
            // ActionNode
            // Visit uFrame.Actions.Comparisons.LessThan
            ActionNode13_Result = uFrame.Actions.Comparisons.LessThan(ActionNode13_a, ActionNode13_b, ActionNode13_yes, ActionNode13_no);
            ActionNode196_first = Group.MainButton.handStretched;
            ActionNode196_second = ActionNode13_Result;
            // ActionNode
            // Visit ConditionsUtils.bothTrue
            ConditionsUtils.bothTrue(ActionNode196_first, ActionNode196_second, ActionNode196_yes, ActionNode196_no);
        }
    }
}
