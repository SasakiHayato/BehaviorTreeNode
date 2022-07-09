using UnityEngine;
using BehaviorTree.Execute;

/// <summary>
/// Debug�p��AI����
/// </summary>
public class ConditionConsole : Conditional
{
    protected override void Init()
    {
        Debug.Log("ConditionalInit");
    }

    protected override void SetUp(GameObject user)
    {
        Debug.Log($"ConditionalSetUp. UserName{user.name}");
    }

    protected override bool Try()
    {
        Debug.Log("Try");
        return true;
    }
}
