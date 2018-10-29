using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSpawnScript : MonoBehaviour

{
    
    public GameObject DiceObject;
    private bool isThrown = false;

    public void DiceThrow()
    {
        if (isThrown == false) {
            for (int i =0 ; i < 5; i++)
        {
            Instantiate(DiceObject, transform.position, transform.rotation);

                
                
        }
            isThrown = true;
        }

        else
        {
            isThrown = false;
};
    }


}

