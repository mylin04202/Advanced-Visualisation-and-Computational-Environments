using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public float speed;
    public float turnSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            return;
        }

        float x = Input.GetAxis("Horizontal");
        transform.Translate(x*turnSpeed*Time.deltaTime, 0, speed * Time.deltaTime );

        var c = Camera.main.transform;
        Quaternion cur = c.rotation;
        Quaternion target = cur * Quaternion.Euler(0, 0, x * 1.5f);
        Camera.main.transform.rotation = Quaternion.Slerp(cur,target,0.5f);


        if (transform.position.x <-16 || transform.position.x > 16)
        {
            transform.Translate(0, -10 * Time.deltaTime, 0);
        }
        if (transform.position.y<-20)
            {
            Debug.Log(1111111);
            Time.timeScale = 0;
        }

    }
}
