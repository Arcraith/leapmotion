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
    using LeapDB;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class DifficultySystemHardDifficultyHandler {
        
        public Difficulty Group;
        
        private LeapDB.HardDifficulty _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private string ActionNode251_name = default( System.String );
        
        private string StringNode252 = "Difficulty";
        
        private UnityEngine.GameObject ActionNode251_result = default( UnityEngine.GameObject );
        
        private object ActionNode253_toCheck = default( System.Object );
        
        private LeapDB.Difficulty ActionNode254_component = default( LeapDB.Difficulty );
        
        private LeapDB.Difficulties ActionNode254_level = default( LeapDB.Difficulties );
        
        private string ActionNode254_type = default( System.String );
        
        private string StringNode255 = "hard";
        
        private LeapDB.Difficulties ActionNode383_level = default( LeapDB.Difficulties );
        
        private LeapDB.UpdateExcerciseScreen PublishEventNode384_Result = default( LeapDB.UpdateExcerciseScreen );
        
        public LeapDB.HardDifficulty Event {
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
            ActionNode251_name = StringNode252;
            // ActionNode
            // Visit GameObjectUtils.findGameObject
            GameObjectUtils.findGameObject(ActionNode251_name, out ActionNode251_result);
            ActionNode253_toCheck = ActionNode251_result;
            // ActionNode
            // Visit ConditionsUtils.isNull
            ConditionsUtils.isNull(ActionNode253_toCheck, ActionNode253_yes, ActionNode253_no);
        }
        
        private void ActionNode253_yes() {
        }
        
        private void ActionNode253_no() {
            ActionNode254_component = this.Group;
            ActionNode254_level = Group.level;
            ActionNode254_type = StringNode255;
            // ActionNode
            // Visit GameObjectUtils.setState
            GameObjectUtils.setState(ActionNode254_component, ActionNode254_level, ActionNode254_type);
            ActionNode383_level = Group.level;
            // ActionNode
            // Visit ExcerciseUtils.setDifficultyExcercises
            ExcerciseUtils.setDifficultyExcercises(ActionNode383_level);
            // PublishEventNode
            var PublishEventNode384_Event = new UpdateExcerciseScreen();
            System.Publish(PublishEventNode384_Event);
            PublishEventNode384_Result = PublishEventNode384_Event;
        }
    }
}