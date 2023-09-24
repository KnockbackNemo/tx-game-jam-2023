using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PopUpComposeEmail : MonoBehaviour
{
    public GameObject SetObjectActive;
    // Start is called before the first frame update
    void Start()
    {
        SetObjectActive.SetActive(false);

    }

    // Update is called once per frame
    public void makeNewEmail() {
        SetObjectActive.SetActive(true);
        Debug.Log("New email button has been clicked");
    }
}
