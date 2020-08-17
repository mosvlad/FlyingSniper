using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    //скорость объекта
    public Vector2 speed = new Vector2(10, 10);
    //направление движения
    public Vector2 direction = new Vector2(-1, 0);
    private Vector2 movement;
  

    // Update is called once per frame
    void Update()
    {
        //перемещнеие
        movement = new Vector2(
            speed.x * direction.x,
            speed.y * direction.y);
        
    }
}
