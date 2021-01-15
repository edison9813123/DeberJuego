using Entidades;
using Interfaces;
using System;
using Dato;
using PersistenciaUno;
using PersistenciaDos;
using PersistenciaTres;
using PersistenciaCuatro;
using PersistenciaCinco;
using LightInject;
using Di.LightInject;

namespace Di
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inicio");
            Console.WriteLine("¡GO");
            Console.WriteLine(" Jugador: ");
            var container = new LightInject.ServiceContainer();

            container.Register<IPersistencia, Persistencia>();
            var instanceUno = container.GetInstance<IPersistencia>();
            //Assert.IsInstanceOfType(instance, typeof(Foo));
            container.Register<IPersistenciaDos, Persistencia2>();
            var instanceDos = container.GetInstance<IPersistenciaDos>(); 
            
            container.Register<IPersistenciaTres, Persistencia3>();
            var instanceTres = container.GetInstance<IPersistenciaTres>();

            container.Register<IPersistenciaCuatro, Persistencia4>();
            var instanceCuatro = container.GetInstance<IPersistenciaCuatro>();

            container.Register<IPersistenciaCinco, Persistencia5>();
            var instanceCinco = container.GetInstance<IPersistenciaCinco>();
            
         

            Datos dato = new Datos(instanceUno,instanceDos,instanceTres,instanceCuatro,instanceCinco);

            Acciones acciones = new Acciones("CORRER","DORMIR","JUGAR");

            Avatar avatar = new Avatar("ERICK","JOSETH","DEIVID","EDISON","JOSE");

            Nivel nivel = new Nivel("Basico","Normal","Intermedio","Dificil","Dios");

            dato.Registar(avatar, nivel, acciones);

        }

    }
}

