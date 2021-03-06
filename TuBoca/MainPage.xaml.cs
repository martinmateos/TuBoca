﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using TuBoca.Modelos;
using TuBoca.Paginas;
using Xamarin.Forms;
using System.Linq;

namespace TuBoca
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {//MainPage muestra los accesos al test y la informacion sobre carreras y universidades.

        //variables

        //fin variables

        ListUser ObjListUser = new ListUser();
        public MainPage()
        {
            InitializeComponent();
            ObjListUser = new ListUser();
        }

        private async void BtnGuardarUser_Clicked(object sender, EventArgs e) //recordar volver a poner async para navegar entre paginas
        {
            //CreateUser();
            //SerializarUser();
            await Navigation.PushAsync(new Test());
        }

        private void CreateUser(int id=1) //Crea un usuario y lo agrega a la lista Usuarios.
        {
            Usuario usuario = new Usuario()
            {
                ID = id++,
                Nombre = EntName.Text,
                Apellido = EntLastName.Text
            };
            ObjListUser.usuarios.Add(usuario);
        }

        private void SerializarUser()
        {
            string jsonFileName = "Usuario.json";

            var assembly = typeof(TuBoca.MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");

            using (var writer = new StreamWriter(stream))
            {
                var jsonString = JsonConvert.SerializeObject(ObjListUser);
                writer.Write(jsonString);
            }
        }

        private async void Uni_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Universidades());
        }
    }
}
 