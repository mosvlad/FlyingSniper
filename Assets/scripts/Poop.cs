 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class Poop : MonoBehaviour {
 
     public GameObject Target;
     private Animator ComAnimator;
     public string TargetAnimation;
     public int ButtonNumber;
 
     void Start (){
         ComAnimator = Target.GetComponent<Animator> ();
     }


    void Update()
    {
        if (Input.GetMouseButtonDown(ButtonNumber))
        {
            ComAnimator.Play(TargetAnimation);
        }
        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");

        if (shoot)
        {
            WeaponScript weapon = GetComponent<WeaponScript>();

            if (weapon != null)
            {
                weapon.Attack(false);
            }
        }
    }
 }