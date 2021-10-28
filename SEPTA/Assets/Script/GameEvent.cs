using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public GameObject mainstructure;
    public GameObject loadscreen;
    public GameObject menu;
    public GameObject scan;
    public GameObject update;
    public GameObject help;
    public GameObject setting;
    public GameObject settingButton;
    public GameObject destination;
    public GameObject bottombar;
    public GameObject bottombarline;




    // Start is called before the first frame update
    void Start()
    {
        loadscreen.SetActive(true);
        mainstructure.SetActive(false);
        menu.SetActive(false);
        scan.SetActive(false);
        update.SetActive(false);
        help.SetActive(false);
        setting.SetActive(false);
        settingButton.SetActive(false);
        destination.SetActive(false);
        bottombarline.SetActive(false);
        bottombar.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
