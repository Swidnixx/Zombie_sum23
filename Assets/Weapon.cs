using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform gunEnd;
    public Transform gunDir;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, 
                gunEnd.position, 
                Quaternion.LookRotation(gunDir.position-gunEnd.position));
            //Debug.Break(); //Pauza
        }
    }
}
