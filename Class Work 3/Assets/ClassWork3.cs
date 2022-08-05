using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassWork3 : MonoBehaviour
{
    string heroName = "Goku";
    int heroPower = 220;
    string villainName = "Knight";
    int villainPower = 220;
    float playerSpeed = 4.4f;
    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villainPower)
        {
            print("the hero is stronger than th villain");
        }
        else if (heroPower == villainPower)
        {
            print("The hero and the villian powers are the same");
        }
        else
        {
            print("The villain is stronger than the hero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetSpeed(float newspeed = 2.5f)
    {
        print("old speed is" + playerSpeed);
        playerSpeed = newspeed;
        print("new speed is" + playerSpeed);
    }
}
