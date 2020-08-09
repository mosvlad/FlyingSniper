using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //скорость движения
    public Vector2 speed = new Vector2(250, 250);
    //направление движения
    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //извлечь информацию оси
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        //движение в каждом напрвлении
        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);
    }

    void FixedUpdate()
    {
        //перемещение игрового объекта
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}
