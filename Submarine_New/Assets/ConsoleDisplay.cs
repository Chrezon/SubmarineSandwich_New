using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleDisplay : MonoBehaviour
{
    public Console console;

    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = console.artwork;
        this.name = console.name; 
    }
}
