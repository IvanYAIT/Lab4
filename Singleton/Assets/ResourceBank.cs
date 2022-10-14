using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBank
{
    #region Singleton1
    /*
    private static ResourceBank instance;
    public static ResourceBank Instance
    {
        get
        {
            if (instance == null)
                instance = new ResourceBank();
            return instance;
        }
    }
    */
    #endregion

    #region Singleton2
    /*
    static ResourceBank() {}
    private ResourceBank() {}

    private static readonly ResourceBank instance = new ResourceBank();

    public static ResourceBank Instance
    {
        get => instance;
    }
    */
    #endregion



    public void DebugResource()
    {
        Debug.Log("DebugResource");
    }
}
