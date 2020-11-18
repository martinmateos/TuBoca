﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TuBoca.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace TuBoca.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test : ContentPage
    {
        public Test()
        {
            InitializeComponent();
        }

        void LoadEnunciado ()
        {
            string jsonFileName = "Enunciados.json";
            ListEnunciado ObjListEnunciado = new ListEnunciado();
            var assembly = typeof(Test).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();

                //Convirtiendo el arreglo de objetos JSON en una lista generica
                ObjListEnunciado = JsonConvert.DeserializeObject<ListEnunciado>(jsonString);
            }
            //listViewEnunciado.ItemSource = ObjListEnunciado.enunciados;
        }
    }
}