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
    
    
    public class MenuSystemUpdateHandler {
        
        public MenuButton Group;
        
        private uFrame.ECS.ISystemUpdate _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private bool ActionNode218_value = default( System.Boolean );
        
        private bool ActionNode177_value = default( System.Boolean );
        
        private UnityEngine.GameObject ActionNode182_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode182_state = default( System.Boolean );
        
        private bool BoolNode185 = true;
        
        private UnityEngine.GameObject ActionNode183_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode183_state = default( System.Boolean );
        
        private UnityEngine.GameObject ActionNode184_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode184_state = default( System.Boolean );
        
        private UnityEngine.GameObject ActionNode178_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode178_state = default( System.Boolean );
        
        private bool BoolNode179 = false;
        
        private UnityEngine.GameObject ActionNode180_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode180_state = default( System.Boolean );
        
        private UnityEngine.GameObject ActionNode181_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode181_state = default( System.Boolean );
        
        private UnityEngine.GameObject ActionNode219_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode219_state = default( System.Boolean );
        
        private bool BoolNode222 = false;
        
        private UnityEngine.GameObject ActionNode220_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode220_state = default( System.Boolean );
        
        private UnityEngine.GameObject ActionNode221_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode221_state = default( System.Boolean );
        
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
            ActionNode218_value = Group.Button.active;
            // ActionNode
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode218_value, ActionNode218_yes, ActionNode218_no);
        }
        
        private void ActionNode177_yes() {
            ActionNode182_obj = Group.MainButton.easybutton.gameObject;
            ActionNode182_state = BoolNode185;
            // ActionNode
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode182_obj, ActionNode182_state);
            ActionNode183_obj = Group.MainButton.mediumbutton.gameObject;
            ActionNode183_state = BoolNode185;
            // ActionNode
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode183_obj, ActionNode183_state);
            ActionNode184_obj = Group.MainButton.hardbutton.gameObject;
            ActionNode184_state = BoolNode185;
            // ActionNode
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode184_obj, ActionNode184_state);
        }
        
        private void ActionNode177_no() {
            ActionNode178_obj = Group.MainButton.easybutton.gameObject;
            ActionNode178_state = BoolNode179;
            // ActionNode
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode178_obj, ActionNode178_state);
            ActionNode180_obj = Group.MainButton.mediumbutton.gameObject;
            ActionNode180_state = BoolNode179;
            // ActionNode
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode180_obj, ActionNode180_state);
            ActionNode181_obj = Group.MainButton.hardbutton.gameObject;
            ActionNode181_state = BoolNode179;
            // ActionNode
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode181_obj, ActionNode181_state);
        }
        
        private void ActionNode218_yes() {
            ActionNode177_value = Group.Button.selected;
            // ActionNode
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode177_value, ActionNode177_yes, ActionNode177_no);
        }
        
        private void ActionNode218_no() {
            ActionNode219_obj = Group.MainButton.easybutton.gameObject;
            ActionNode219_state = BoolNode222;
            // ActionNode
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode219_obj, ActionNode219_state);
            ActionNode220_obj = Group.MainButton.mediumbutton.gameObject;
            ActionNode220_state = BoolNode222;
            // ActionNode
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode220_obj, ActionNode220_state);
            ActionNode221_obj = Group.MainButton.hardbutton.gameObject;
            ActionNode221_state = BoolNode222;
            // ActionNode
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode221_obj, ActionNode221_state);
            // SetVariableNode
            Group.Button.selected = (System.Boolean)BoolNode222;
        }
    }
}
