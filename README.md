# MuxicMatchApi
Una librería que utiliza la Api de musixmatch, para hallar información de canciones y la letra de la misma

***DOCUMENTATION FOR MUXICMATCHAPI 2.0.0***

## Important: This library is Asynchronus

Once you installed the package, you have to instance the class:

Example:

```C#
using MuxicMatchApi;

namespace *Something*
{
  void static Main()
  {
     var client = new MuxicMatchClient("Your Api key");
  }
}
```

## Functions:

In this version there are 2 functions:


GetTrackAsync: This method is a instance of the class, so you have to use like this:
```C#
using MuxicMatchApi;

namespace *Something*
{
  static async Task Main()
  {
     var client = new MuxicMatchClient("Your Api key");
     var track = await client.GetTrackAsync(*stuff*);
  }
}
```

GetLyricsAsync: This method is static so you don't have need the MuxicMatchClient instance, like these:

```C#
using MuxicMatchApi;

namespace *Something*
{
  static async Task Main()
  {
     var lyrics = await MuxicMatchClient.GetLyricsAsync(*stuff*)
  }
}
```


That's all for 2.0.0

Thanks for download this package

Author: Pro0072006
