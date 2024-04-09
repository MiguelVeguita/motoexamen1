using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject pla1, pla2, pla3, pla4;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        num = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (num == 1)
            {
                num = 4;
            }
            else
            {
                num--;
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (num == 4)
            {
                num = 1;
            }
            else
            {
                num++;
            }
        }


        if (num == 1)
        {
            pla1.gameObject.SetActive(true);
            pla2.gameObject.SetActive(false);
            pla3.gameObject.SetActive(false);
            pla4.gameObject.SetActive(false);
        }
        if (num == 2)
        {
            pla1.gameObject.SetActive(false);
            pla2.gameObject.SetActive(true);
            pla3.gameObject.SetActive(false);
            pla4.gameObject.SetActive(false);
        }
        if (num == 3)
        {
            pla1.gameObject.SetActive(false);
            pla2.gameObject.SetActive(false);
            pla3.gameObject.SetActive(true);
            pla4.gameObject.SetActive(false);
        }
        if (num == 4)
        {
            pla1.gameObject.SetActive(false);
            pla2.gameObject.SetActive(false);
            pla3.gameObject.SetActive(false);
            pla4.gameObject.SetActive(true);
        }
    }
}
