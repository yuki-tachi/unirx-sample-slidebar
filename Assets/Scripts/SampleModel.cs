using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public enum PlayerState
{
    Stopped,
    Playing
}
public class SampleModel : MonoBehaviour
{
    private PlayerState PlayerState;
    private float PlaybackTime;
    private bool IsLoop = true;

    // Start is called before the first frame update
    void Start()
    {
        var rp = new ReactiveProperty<int>(15);
        rp.Value = 20;
        var currentValue = rp.Value;
        Debug.Log(currentValue);
        rp.Subscribe(x => Debug.Log(x));

        rp.Value = 30;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
