using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{

    public static AudioClip big_explotion, short_explosion, death, button_click, shoot;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        big_explotion = Resources.Load<AudioClip>("big_explotion");
        death = Resources.Load<AudioClip>("death");
        short_explosion = Resources.Load<AudioClip>("short_explotion");
        button_click = Resources.Load<AudioClip>("button_click");
        shoot = Resources.Load<AudioClip>("shoot");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch(clip){
            case "big_explotion":
                audioSrc.PlayOneShot(big_explotion);
                break;

            case "small_explotion":
                audioSrc.PlayOneShot(short_explosion);
                break;

            case "death":
                audioSrc.PlayOneShot(death);
                break;

            case "shoot":
                audioSrc.PlayOneShot(shoot);
                break;

            case "button_click":
                audioSrc.PlayOneShot(button_click);
                break;
        }
    }
}
