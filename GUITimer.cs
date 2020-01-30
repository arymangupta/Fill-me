using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text displayTimerText;
    public float maxTime = 60f;
    private Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = new Timer(maxTime , true);
    }

    // Update is called once per frame
    void Update()
    {
        DisplayTimer();
    }

    void DisplayTimer() {
        timer.RunTimer();
        displayTimerText.text = timer.TimeRemaining().ToString();

        /*Game Over Logic goes here*/
        if(timer.IsTimeOut()){
            
        }
    }
}
