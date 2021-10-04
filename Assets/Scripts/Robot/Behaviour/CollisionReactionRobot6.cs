using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReactionRobot6 : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    
    public void Reaction(GameObject goal)
    {
        var goalRobot = goal.GetComponent<Robot>();
        if (goalRobot)
        {
            var goalSprite = goal.GetComponentInChildren<SpriteRenderer>();
            if (goalSprite)
            {
                spriteRenderer.sprite = goalSprite.sprite;
                //Вызов анимации полёта
            }
        }
    }
}
