using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 
{

    // Use this for initialization
    void Start()
    {
        Operators();

        LOL();

        HAHA();
    }



    public void Operators()
    {
            Debug.Log("Multiplikative Operatoren:  " + (3 * 4));
            Debug.Log("Multiplikative Operatoren:  " +  (6 / 2));
            Debug.Log("Multiplikative Operatoren:  "  +( 4 % 3));

            Debug.Log("Additive Operatoren: " + (8 + 2));
            Debug.Log("Additive Operatoren: " + (7 - 6));

            Debug.Log("Relationale Operatoren: " + (2 < 5));
            Debug.Log("Relationale Operatoren: " + (5 <= 9));
            Debug.Log("Relationale Operatoren: " + (6 > 3));
            Debug.Log("Relationale Operatoren: " + (1 >= 1));

            Debug.Log("Gleichheits Operatoren: " + (4 == 4));
            Debug.Log("Gleichheits Operatoren:  " + (1 != 1));

            //Debug.Log("Logische Operatoren: " + (2 & 7));
            // Debug.Log("Logische Operatoren:  ⎪ (4 ⎪ 7));
            // Debug.Log("Logische Operatoreen c " + (etc 2));

    }  //erste tests mit operatoren


    public void LOL()
    {
        Debug.Log(100+87);
    }



     public void HAHA()
    {
        Debug.Log("Hallo");
    }
	



	// Update is called once per frame
	void Update () 
    {
		
	}


}
