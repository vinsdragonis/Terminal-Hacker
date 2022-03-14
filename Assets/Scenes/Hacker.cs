using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Terminal.WriteLine("Terminal Hacker \n\nYou rule the cyber underworld. \nChoose what you wanna hack into : ");
        Terminal.WriteLine("1. Neighbour's PC.");
        Terminal.WriteLine("2. The Bank.");
        Terminal.WriteLine("3. GOOGLE. \n");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
