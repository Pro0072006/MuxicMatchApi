# MuxicMatchApi
Una librería que utiliza la Api de musixmatch, para hallar información de canciones y la letra de la misma

Buscalo en Nuget.org: [MuxicMatchApi](https://www.nuget.org/packages/MuxicMatchApi/)

New features: [Features](https://github.com/pro0072006/MuxicMatchApi/blob/main/Updates_notice.md)

***DOCUMENTACION PARA MUXICMATCHAPI 2.1.0***

## Importante: Esta libreria es Asincrona

Una vez hayas instalado el paquete tienes que saber, hay 2 clases:

-MuxicMatchClient

-LyricsFinder

## MuxicMatchClient
Esta es una instancia de la clase, lo creas asi:

```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new MuxicMatchClient("Tu Api key");
        }
    }
}
```
### Funciones:

En esta version hay 2 funciones: 


GetTrackAsync: Este metodo es una instacia de la clase, asi que lo tienes que usar asi:
```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new MuxicMatchClient("Your Api key");
            var track = await client.GetTrackAsync("songTitle", "songartist");

            //Este retornara una clase TrackModel, cuyos atributos son:
            /*
             *  int Track_Id 
                string Track_Name 
                string Album_Name 
                string Artist_Name
                string Track_Url 
             */
        }
    }
}
```

GetLyricsAsync: Este metodo es una instancia, Asi que, (Este retornara un string con la cancion):

```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new MuxicMatchClient("Your Api key");
            string track = await client.GetMusixMatchLyricsApi("songTitle", "songArtist");

        }
    }
}
```

### IMPORTANTE: SI TIENES UNA API KEY PERSONAL, ESTE SOLO RETORNARA EL 30% DE LA CANCION, ASI QUE SI QUIERES LA LETRA COMPLETA, SIGUE LEYENDO.

## LyricsFinder
Esta es una clase estatica, esta contiene 4 metodos por ahora para buscar letras, esto significa que no necesitas una Api key:

### Functions

GetOvhLyricsAsync: Esta consultara en OVH.API para la letra
Eejemplo:
```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var lyrics = LyricsFinder.GetOvhLyricsAsync("songTitle", "songArtist");
            //It will return a string with the lyrics, or a string with a error
        }
    }
}
```
GetGeniusLyriscAsync: Este consultara Genius para la letra
EJemplo:

```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var lyrics = LyricsFinder.GetGeniusLyrics("songTitle", "songArtist");
            //It will return a string with the lyrics
        }
    }
}
```

GetGeniusLyricsWithVictoria: Si estas trabajando con [Victoria](https://github.com/Yucked/Victoria) y necesitas traer la letra de la cancion, utiliza este metodo
Ejemplo:
```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var lyrics = LyricsFinder.GetGeniusLyricsWithVictoria("player.track.title");
            //this will return a string with the lyrics
        }
    }
}
```
Importante: Este añadido es Beta, Asi que puede ser inestable o no funcione, pero normalmente lo hara :)

GetAzlyrics: Este consultara a Azlyrics.com por la letra
```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace Tutorial
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var track = await LyricsFinder.GetAzLyrics("uprising", "muse");
            Console.WriteLine(track);

            /*
            Paranoia is in bloom,
            The PR transmissions will resume
            They'll try to push drugs that keep us all dumbed down
            And hope that we will never see the truth around
            (so come on)
            */
        }
    }
}
```

Eso es todo por la 2.5.0

Gracias por descargar el paquete

Author: Pro0072006
