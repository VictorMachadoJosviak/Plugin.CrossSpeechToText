# Plugin.CrossSpeechToText


A plugin where you can easily convert spoken audio to text



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
