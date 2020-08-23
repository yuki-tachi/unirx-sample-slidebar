using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class SamplePresenter : MonoBehaviour
{
    [SerializeField]
    private SampleModel Model = null;

    [SerializeField]
    private SampleView View = null;

    void Start()
    {
        Model.Stop();
        View.SetMusicLength(Model.MusicLength);

        Model.PlaybackTime.Subscribe(x =>
        {
            Debug.Log("playback: " + x);
            View.SetPlaybackTime(x);

        });

        Model.CurrentPlayerState.Subscribe(state =>
        {
            View.TogglePlayStopButton(state != PlayerState.Playing);
        });


        View.PlayButton.onClick.AsObservable().Subscribe(_ =>
        {
            Model.Play();
        });

        View.StopButton.onClick.AsObservable().Subscribe(_ =>
        {
            Model.Stop();
        });

        View.LoopToggle.OnValueChangedAsObservable().Subscribe(isOn =>
        {
            Model.SetLoop(isOn);
        });

        View.SeekBar.onValueChanged.AddListener((value) =>
        {
            Model.PlaybackTime.Value = value;

        });

        View.SeekBar.OnPointerDownAsObservable().Subscribe(pointerEventData =>
        {
            Model.Stop();
        });
    }
}
