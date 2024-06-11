# TLabWebViewMRTK3
Sample project for manipulating TLabWebView from MRTK3

# Document
[document is here](https://tlabgames.gitbook.io/tlabwebview)

## Note

<details><summary>please see here</summary>

### This Repository only for Oculus Quest 2
This is a project I created for Oculus Quest 2, using the MRTK3, but it does not work with HoloLens. This is because the WebView used is an Oculus (or Android) dependent system.

</details>

## ScreenShot
<img src="Media/screenshot.gif" width="512"></img>

## Operating Environment
- Oculus Quest 2
- Qualcomm Adreno650

## Requirements
- Unity 2021.3 LTS
- [MRTK3](https://learn.microsoft.com/ja-jp/windows/mixed-reality/mrtk-unity/mrtk3-overview/)
- [TLabVKeyborad](https://github.com/TLabAltoh/TLabVKeyborad.git)
- [TLabWebView](https://github.com/TLabAltoh/TLabWebView.git)

## Get Started

### Installing

Clone the repository with the following command

```
git clone https://github.com/TLabAltoh/TLabWebViewMRTK3.git

cd TLabWebViewMRTK3

git submodule update --init
```

### Set Up

- Build Settings

| Property      | Value   |
| ------------- | ------- |
| Platform      | Android |

- Project Settings

| Property          | Value     |
| ----------------- | --------- |
| Color Space       | Linear    |
| Minimum API Level | 29        |
| Target API Level  | 31        |


- Add the following symbols to Project Settings --> Player --> Other Settings (to be used at build time)

```
UNITYWEBVIEW_ANDROID_USES_CLEARTEXT_TRAFFIC
```
```
UNITYWEBVIEW_ANDROID_ENABLE_CAMERA
```
```
UNITYWEBVIEW_ANDROID_ENABLE_MICROPHONE
```

### Sample Scene
```
Assets\Scenes\SampleScene.unity
```

## Link
- [Source code of the java plugin used](https://github.com/TLabAltoh/TLabWebViewPlugin.git)
