using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class CollisionReactionRobot8 : MonoBehaviour
{
    public VisibilityReaction visibilityReaction;
    public void Reaction(GameObject goal)
    {
        var goals = visibilityReaction.goals;
        for (int i = goals.Count - 1; i >= 0; i--)
        {
            var _goal = goals[0];
            _goal.SetActive(false);
            Destroy(_goal);
        }
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
