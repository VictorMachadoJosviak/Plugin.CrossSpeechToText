<img align="left" src="https://i.imgur.com/bep823D.png" width="100" height="100"> <h1 style="margin-left:50px">Plugin.CrossSpeechToText</h1>



A plugin where you can easily convert spoken audio to text


# Getting Started

| Platform | Description |
| --- | --- |
| `Android` | OK |
| `iOS` | Comming soon |
| `UWP` | Comming soon |

# Android

In your MainActivity.cs
```
  protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
  {
       base.OnActivityResult(requestCode, resultCode, data);
       Plugin.CrossSpeechToText.Droid.SpeechToText.OnActivityResult(requestCode, resultCode, data);
  }
```

# PCL

```
 private async void Button_Clicked(object sender, EventArgs e)
 {
     var result = await CrossSpeechToText.StartVoiceInput("Voice Input!");
     txtResult.Text = result;
 }
 
```
# Screenshots
<img align="left" src="https://i.imgur.com/rZJSPzd.png" width="225" height="400">
<img align="left" src="https://i.imgur.com/Jk2fDPs.png" width="225" height="400">

