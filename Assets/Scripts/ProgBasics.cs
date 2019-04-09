using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start () {

    Debug.Log("Multiplikative Operatoren: * " + (3 * 4));
    Debug.Log("Multiplikative Operatoren:  / " + (6 / 2));
    Debug.Log("Multiplikative Operatoren:  % " + (4 % 3));

    Debug.Log("Additive Operatoren:  + " + (8 + 2));
    Debug.Log("Additive Operatoren:  - " + (7 - 6));

    Debug.Log("Relationale Operatoren:  < " + (2 < 5));
    Debug.Log("Relationale Operatoren:  <= " + (5 <= 9)); 
    Debug.Log("Relationale Operatoren:  > " + (6 > 3));
    Debug.Log("Relationale Operatoren:  >= " + (4 >= 1));

    Debug.Log("Gleichheits Operatoren:  == " + (4 == 4));
    Debug.Log("Gleichheits Operatoren:  != " + (3 != 1));

    Debug.Log("Logische Operatoren:  & " + (2 & 7));
    Debug.Log("Logische Operatoren:  ⎪ " + (4 ⎪ 7));
    Debug.Log("Logische Operatoren:  etc " + ( etc 2));

        //erste tests mit operatoren
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
