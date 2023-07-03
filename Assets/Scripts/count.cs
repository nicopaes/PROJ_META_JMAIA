using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count : MonoBehaviour
{
    public AudioSource chickenWin;
    public AudioSource eggWin;
    public AudioSource tie;
    public AudioSource finalMsg;

    public collisionEgg egg;
    public collisionChicken chicken;

    private void Start() 
    {
        Camera.main.gameObject.AddComponent<AudioListener>();
    }

    void Update()
    {
        if (egg.eggCount > chicken.chickenCount)
        {
            Debug.Log("The Egg is the winner!");
            eggWin.Play();
        }
        else if (egg.eggCount < chicken.chickenCount){
            Debug.Log("The Chicken is the winner!");
            chickenWin.Play();
        }
        else
        {
            Debug.Log("It's a tie!");
            tie.Play();
        }
    }	

}
