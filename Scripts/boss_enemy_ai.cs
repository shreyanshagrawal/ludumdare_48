using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss_enemy_ai : MonoBehaviour
{

    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    private int hit;
    public Button win;


    public Transform player;

    private float timeBtwShot;
    public float strtTimeBtwShot;

    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        timeBtwShot = strtTimeBtwShot;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }else if(Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
           transform.position = this.transform.position;
        
        }else if(Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }

        if (timeBtwShot <= 0)
        {
            Instantiate(projectile, player.position, Quaternion.identity);
            timeBtwShot = strtTimeBtwShot;
        }
        else
        {
            timeBtwShot -= Time.deltaTime;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bullet"))
        {
            hit++;
            if(hit >= 10)
            {
                Destroy(gameObject);
                win.enabled = true;
                win.gameObject.SetActive(true);
            }
        }
    }

}
