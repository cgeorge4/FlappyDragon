using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class ColumnController : MonoBehaviour
{
    public GameObject prefab;
    public float minY, maxY;

    float timer;
    public float maxTime;
    void Start()
    {
        //spawn a column
        spawn();
    }

    void Update()
    {
        //spawn columns every x amount of seconds
        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            spawn();
            timer = 0;
        }
    }

    void spawn()
    {
        float randYpos = Random.Range(minY, maxY);

        GameObject g = Instantiate(prefab);
        g.transform.position = new Vector2(transform.position.x, randYpos);
        //g.transform.forward = transform.forward;
    }
}*/
