# unirx-sample-slidebar
![uniseekbar output](https://user-images.githubusercontent.com/43042148/91966802-4e4aa180-ed4d-11ea-987c-2f462ff0ac4d.gif)

デリゲートで実装されたMPVパターンをUnirxで書き換える
https://virtualcast.jp/blog/2019/11/mvp_pattern_on_unity/

## 仕様
- Play/Stopボタンで再生/一時停止ができる
- Loopのオンオフができる
- 曲を最後まで再生した場合
  - Loopがオンの場合: 最初から再生
  - Loopがオフの場合: 最後で停止
- sliderを動かすと時間部分が連動する
  - sliderを触ると一時停止
