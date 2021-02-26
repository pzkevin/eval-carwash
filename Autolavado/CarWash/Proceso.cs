﻿using System;
using System.Collections.Generic;
using System.Text;
using Autolavado.Personas;

namespace Autolavado.Personas
{
    public class Proceso : Persona
    {
        //iniciar tipos de usuarios para usar menu
        Cajero cajeroMenu = new Cajero();
        Cliente clienteMenu = new Cliente();


        List<Cliente> listaLavado = new List<Cliente>();
        List<EtapaLavado> procedimiento = new List<EtapaLavado>();

        public bool Inicio(string lavado)
        {
            
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Bienvenido al autolavado");
                Console.WriteLine("\nUsted es ¿Cliente o Cajero?");
                Console.WriteLine("Si es Cliente ingrese 1:");
                Console.WriteLine("Si es Cajero ingrese 2:");
                string respuestaUsuario = (Console.ReadLine());
                if (respuestaUsuario == ("1"))
                {
                    clienteMenu.menu();
                }
                if (respuestaUsuario == ("2"))
                {
                    cajeroMenu.menu();
                }
            }
            

            return true;
        }
    }
}
