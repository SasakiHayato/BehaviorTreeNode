using GraphProcessor;
using UnityEngine;
using BehaviorTree;

namespace BehaviorTreeEditor
{
    public class ReapterNode : BaseNode
    {
        [Output("ConectBranch", allowMultiple = true)] BranchNode _branchNode;

        [SerializeField] GameObject _user;

        public override string name => "Reapter";

        protected override void Process()
        {
            
        }
    }
}
