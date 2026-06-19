using JetBrains.Annotations;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class NotesManager_M : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<bool> Notes_timing = new List<bool>();
    void Start()
    {
        for(int i = 0;i < 5;i++){
            Notes_timing.Add(false);
        }
    }

    // Update is called once per frame

}
