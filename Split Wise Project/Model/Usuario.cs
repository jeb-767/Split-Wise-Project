﻿using Split_Wise_Project.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Wise_Project.Model
{
    public class Usuario
    {
        public int ID {  get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Descripcion { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Foto { get; set; }
        public List<Usuario> amigos { get; set; }

        public Usuario() 
        {
            amigos = new List<Usuario>();
        }

        public Usuario(int _ID , string _Nombre , string _Apellidos , string _Descripcion , string _Correo, int _Telefono , string _Foto)
        {
            amigos = new List<Usuario>();

            this.ID = _ID ;
            this.Nombre = _Nombre ;
            this.Apellidos = _Apellidos ;
            this.Descripcion = _Descripcion;
            this.Correo = _Correo ;
            this.Telefono = _Telefono ;
            this.Foto = _Foto ;
        }

        public List<Usuario> GetAmigos()
        {
            DataAcces.DataAccess d = new DataAcces.DataAccess();
            amigos = d.GetAmigos(ID);
            return amigos;
        }

        public Usuario AddAmigo(string Email)
        {
            DataAcces.DataAccess d = new DataAcces.DataAccess();
            return d.AddAmigo(this , Email);
        }

        public void DeleteFriend(string Email)
        {
            DataAcces.DataAccess d = new DataAcces.DataAccess();
            d.DeleteFriend(Email  , this);
        }
    }
}
