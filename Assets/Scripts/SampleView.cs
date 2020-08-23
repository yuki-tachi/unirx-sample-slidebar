using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class SampleView : MonoBehaviour
{
    [SerializeField] public Button PlayButton;
    [SerializeField] public Button StopButton;
    [SerializeField] public Toggle LoopToggle;
    [SerializeField] public Slider SeekBar;
    [SerializeField] public Text PlaybackTime;

    public void SetMusicLength(float musicLength)
    {
        SeekBar.maxValue = musicLength;
    }

    public void TogglePlayStopButton(bool showPlayButton)
    {
        PlayButton.gameObject.SetActive(showPlayButton);
        StopButton.gameObject.SetActive(!showPlayButton);
    }

    public void SetLoopToggle(bool isOn)
    {
        LoopToggle.isOn = isOn;
    }

    public void SetPlaybackTime(float playbackTime)
    {
        SeekBar.value = playbackTime; // シークバーに再生時間をセットする
        this.PlaybackTime.text = TimeSpan.FromSeconds(playbackTime).ToString(@"ss\:fff"); // 表示用に整形してテキストをセット
    }
}
