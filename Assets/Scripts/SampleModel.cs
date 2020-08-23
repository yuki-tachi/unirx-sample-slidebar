using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class SampleModel : MonoBehaviour
{
    public readonly float MusicLength = 3f;
    public ReactiveProperty<PlayerState> CurrentPlayerState = new ReactiveProperty<PlayerState>();
    public ReactiveProperty<float> PlaybackTime = new ReactiveProperty<float>();
    public new ReactiveProperty<bool> IsLoop = new ReactiveProperty<bool>();

    void Update()
    {
        if (CurrentPlayerState.Value == PlayerState.Playing)
        {
            this.PlaybackTime.Value += Time.deltaTime;

            if (MusicLength < this.PlaybackTime.Value)
            {
                if (IsLoop.Value)
                {
                    this.PlaybackTime.Value = 0f;
                }
                else
                {
                    this.PlaybackTime.Value = MusicLength;
                    Stop();
                }
            }

        }
    }

    public void Play()
    {
        this.CurrentPlayerState.Value = PlayerState.Playing;
    }

    public void Stop()
    {
        this.CurrentPlayerState.Value = PlayerState.Stopped;
    }

    public void SetLoop(bool isLoop)
    {
        this.IsLoop.Value = isLoop;
    }
}
