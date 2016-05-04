using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace $safeprojectname$
{
    public static class ObslugaBazyDanych
    {
        private static string podlaczenie =
            "Data Source=.;" +
            "Initial Catalog=$safeprojectname$;" +
            "Integrated Security=True";

        private static SqlConnection podlaczenieDoBazy = new SqlConnection(podlaczenie);

        public static DataTable pobierzTablice(string polecenie)
        {
            SqlCommand poleceniePobierajaceTablice = new SqlCommand(polecenie, podlaczenieDoBazy);
            DataTable wynik = new DataTable();

            try
            {
                SqlDataAdapter zarzadcaDanych = new SqlDataAdapter(poleceniePobierajaceTablice);

                poleceniePobierajaceTablice.Connection.Open();
                zarzadcaDanych.Fill(wynik);
            }
            finally
            {
                poleceniePobierajaceTablice.Connection.Close();
            }

            return wynik;
        }

        public static Object pobierzWartosc(string polecenie)
        {
            SqlCommand poleceniePobierajaceWartosc = new SqlCommand(polecenie, podlaczenieDoBazy);
            Object wynik;

            try
            {
                poleceniePobierajaceWartosc.Connection.Open();
                wynik = poleceniePobierajaceWartosc.ExecuteScalar();
            }
            finally
            {
                poleceniePobierajaceWartosc.Connection.Close();
            }
            return wynik;
        }

        public static void wykonajPolecenie(string polecenie)
        {
            SqlCommand polecenieBezWyniku = new SqlCommand(polecenie, podlaczenieDoBazy);

            try
            {
                polecenieBezWyniku.Connection.Open();
                polecenieBezWyniku.ExecuteNonQuery();
            }
            finally
            {
                polecenieBezWyniku.Connection.Close();
            }
        }
    }
}
