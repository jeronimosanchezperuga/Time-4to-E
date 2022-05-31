using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtTime;
    public Text txtTimeFloored;
    public Text txtTimeCustom;

    public float customTime;
    public bool isCounting;
    public float timeToDoSomething;
    public float timeToWait;
    // Start is called before the first frame update
    void Start()
    {
        customTime = 0;
        timeToDoSomething = timeToWait;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time;
        txtTime.text = elapsedTime.ToString();
        txtTimeFloored.text = Mathf.Floor(elapsedTime).ToString();

        txtTimeCustom.text = customTime.ToString();

        if (Time.time > timeToDoSomething)
        {
            Debug.Log("Hacer algo");
            timeToDoSomething += timeToWait;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isCounting = !isCounting;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            customTime = 0;
        }

        if (isCounting)
        {
            customTime += Time.deltaTime;
        }


       
    }
}
