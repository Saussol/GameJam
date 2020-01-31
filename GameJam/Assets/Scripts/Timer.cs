using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public Text timerText;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PassingTime();
    }

    public void PassingTime()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
            timerText.text = time.ToString("F0") + " ";
            Debug.Log(time);
        }
        else if(time <= 0)
        {
            Destroy(Player);
        }
    }
}
