using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class InterfaceKlienta : Form
    {
        private DataTable tablicaKlientow;

        public InterfaceKlienta ()
        {
            InitializeComponent();
        }

        private void InterfaceKlienta_Load (object sender, EventArgs e)
        {
           
            wypelnijRezerwacje(DaneLogowania.Id);
        }



        private void wypelnijRezerwacje (int idKlienta)
        {
            string zapytanieRezerwacji =
                "Select L.NazwaLodzi, R.DataWynajmu, R.DataZwrotu, L.CenaWynajmu"
                + " From [$safeprojectname$].[dbo].[Rezerwacje] R Inner Join $safeprojectname$.dbo.Lodzie L ON R.LodzieId = L.IdLodzi"
                + " Where R.KlienciId = " + idKlienta;

            rezerwacje.DataSource = ObslugaBazyDanych.pobierzTablice(zapytanieRezerwacji);
        }
    }
}
