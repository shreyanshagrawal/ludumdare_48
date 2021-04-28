using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float timer = 900f;
    public GameObject level_1;
    public GameObject level_2;
    public GameObject level_3;
    public GameObject level_4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        
        if (timer <= 898f)
        {
            level_1.SetActive(false);
            level_2.SetActive(true);
        }
        
    }
}
