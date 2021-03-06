﻿using System;
using System.Collections.Generic;
using System.IO;
using Entidades;
using Interfaces;

namespace PersistenciaDos
{
    public class Persistencia2 : IPersistenciaDos
    {

        public new bool Grabar(Avatar avatar)
        {
            File.AppendAllLines("Avatar.txt", new List<string> { avatar.Nombre2});
            Console.WriteLine("Jugador: ");
            Console.WriteLine(avatar.Nombre2);
            return true;
        }
        public new bool Grabar(Acciones acciones)
        {
            File.AppendAllLines("Acciones.txt", new List<string> { acciones.Accion2 });
            Console.WriteLine("Realiza la accion: ");
            Console.WriteLine(acciones.Accion2);
            return true;
        }
        public new bool Grabar(Nivel nivel)
        {
            File.AppendAllLines("Nivel.txt", new List<string> { nivel.Nivel2 });
            Console.WriteLine("Usted esta en el nivel: ");
            Console.WriteLine(nivel.Nivel2);
            return true;
        }
        public new bool Grabar(AvatarPorAccion avatarPorAccion)
        {
            File.AppendAllLines("AvatarPorAccion.txt", new List<string> { avatarPorAccion.NivelId.ToString() });
            return true;
        }
    }

}
