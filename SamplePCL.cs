using System;
using System.Collections.Generic;
using System.Text;
using PCLStorage;
using Xamarin.Forms;

namespace XPost
{
    class SamplePCL:ContentPage
    {
        SamplePCL()
        {
            var entry = new Entry();
            var button = new Button()
            {
                Text = "OK",
                Command = new Command(async () =>
                {
                    // Capturar ruta
                    var folder = FileSystem.Current.LocalStorage;

                    // Crear carpeta
                    var subFolder = await folder.CreateFolderAsync("SubFolder", CreationCollisionOption.OpenIfExists);

                    // Crear carpeta
                    var file = await subFolder.CreateFileAsync("Text.txt", CreationCollisionOption.ReplaceExisting);

                    // Escribir contenido del Entry al fichero
                    await file.WriteAllTextAsync(entry.Text);

                    // leer contenido de fichero
                    var str = await file.ReadAllTextAsync();
                })
            };
        }
    }
}
