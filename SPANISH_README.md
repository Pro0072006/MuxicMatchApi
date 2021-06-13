***DOCUMENTACION PARA MUXICMATCHAPI 2.0.0***

Importante: Esta libreria es Asincrona

Una vez hayas instalado el paquete tienes que instanciar la clase cliente

Ejemplo:
```C#
using MuxicMatchApi;

namespace *Something*
{
  void static Main()
  {
     var client = new MuxicMatchClient("Tu API KEY");
  }
}
```

## Funciones:
En esta version solo hay 2 funciones:

GetTrackAsync: Esta metodo viene con la instancia de la clase, y se utliza asi:

```C#
using MuxicMatchApi;

namespace *Something*
{
  static async Task Main()
  {
     var client = new MuxicMatchClient("Your Api key");
     var track = await client.GetTrackAsync(*Parametros*);
  }
}
```

GetLyricsAsync: Este metodo es estatico asi que no necesitas la instancia de la clase para usarlo

```C#
using MuxicMatchApi;

namespace *Something*
{
  static async Task Main()
  {
     var lyrics = await MuxicMatchClient.GetLyricsAsync(*Parametros*)
  }
}
```


Eso es todo por la version 2.0.0

Gracias por descargar el paquete

Autor: Pro0072006

