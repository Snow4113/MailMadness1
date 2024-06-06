using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FMODBankLoader : MonoBehaviour
{
    public string[] banks;

    void Start()
    {
        foreach (string bank in banks)
        {
            RuntimeManager.LoadBank(bank, true);
        }
    }
}
