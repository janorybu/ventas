﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.BL;
using ventas.Modelos;

namespace ventas
{
    public partial class Login : Form
    {

        UsuariosBL _usuariosBL;

        public Usuario UsuarioAutenticado { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = textBox1.Text;
            var contrasena = textBox2.Text;

            var usuarioAutenticado =_usuariosBL.Autenticar(nombre, contrasena);

            if (usuarioAutenticado != null)
            {
                UsuarioAutenticado = usuarioAutenticado;
                this.Close();
            }else
            {
                MessageBox.Show("Usuario O Contrasena Erronea");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

            
        }

        public void CargarDatos(UsuariosBL usuariosBL)
        {
            _usuariosBL = usuariosBL;
        }
    }
}
