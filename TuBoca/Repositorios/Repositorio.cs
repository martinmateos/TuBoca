using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using TuBoca.Modelos;

namespace TuBoca.Repositorios
{
    public class Repositorio
    {/*
        private SQLiteConnection conn;

        private static Repositorio instancia; //Atributo que se utliza para acceder con el metodo de abajo.
        public static Repositorio Instancia //Metodo con el que se accede a instancia.
        {
            get
            {
                if (instancia == null) //esto es cuando no llamamos al Inicializador
                {
                    throw new Exception("debe llamar al inicializador");
                }

                return instancia;
            }
        }

        //inicializador (se ejecuta una vez)
        public static void Inicializador(string filename)
        {
            if (filename == null)
            {
                throw new ArgumentNullException();
            }

            if (Instancia != null)
            {
                instancia.conn.Close();
            }
                
            instancia = new Repositorio(filename);
        }

        //inicializar la conexion
        private Repositorio(string dbPath) //dbPath es la ruta donde se aloja la base de datos.
        {
            conn = new SQLiteConnection(dbPath);

            conn.CreateTable<Enunciado>();
        }

        public String EstadoMensaje;
        //Agregar Enunciado
        public Enunciado AddEnunciado(string contenido, int id, Personalidad tipo)
        {
            int result = 0;
            try
            {
                result = conn.Insert(new Enunciado()
                {
                    Contenido = contenido,
                    ID = id,
                    Tipo = tipo,
                });
                EstadoMensaje = string.Format("Cantdidad de filas afectadas: {0}", result);
            }
            catch(Exception e)
            {
                EstadoMensaje = e.Message;
            }
        } */
    }
}
