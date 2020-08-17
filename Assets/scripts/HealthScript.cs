using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    //всего хитпоитов
    public int hp = 1;
    //враг или игрок?
    public bool isEnemy = true;
    //наносим урон и проверяем должен ли объект быть уничтоженым
    public void Damage (int damageCount)
    {
        hp -= damageCount;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //это выстрел?
        ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
        if (shot != null)
        {
            //избегайте дружественного огня
            if (shot.isEnemyShot != isEnemy)
            {
                Damage(shot.damage);
                //уничтожить выстрел
                Destroy(shot.gameObject);
            }
        }
    }
}
