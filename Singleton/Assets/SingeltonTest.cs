using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingeltonTest : MonoBehaviour
{
    void Start()
    {
        SingletonComponent.Instance.DebugSingletonComponent();
        //ResourceBank.Instance.DebugResource();
    }
}
