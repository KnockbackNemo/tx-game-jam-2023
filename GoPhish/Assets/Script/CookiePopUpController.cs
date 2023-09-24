using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookiePopUpController : MonoBehaviour
{
    public GameObject winTracker;
    public Text cookieCounterText;
    public int clickCount;
    // Start is called before the first frame update
    void Start()
    {
        clickCount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
         cookieCounterText.text = clickCount.ToString();
        
    }

      public void addClickCount() {
        if (clickCount < 42) {
            clickCount++;
        } else {
            winTracker.GetComponent<Timer>().win = true;
            Debug.Log("Set win as true");

        }
    }
}
