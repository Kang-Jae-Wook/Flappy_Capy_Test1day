using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObject : MonoBehaviour
{

    public GameObject PipeObject;
    float timer = 0;
    public float TimeDiff;
 

    void Start()
    {
        
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > TimeDiff)
        {
            GameObject newPipe = Instantiate(PipeObject);
            newPipe.transform.position = new Vector3(0, Random.Range(-1.83f, 0.3f), 0);
            timer = 0;
            Destroy(newPipe, 10.0f);
        }

        if(Score.score > 15 && Score.score < 35)
        {

        }
    }
}
