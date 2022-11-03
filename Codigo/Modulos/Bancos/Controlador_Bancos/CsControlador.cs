﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo_Bancos;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace Controlador_Bancos
{
    
   public  class CsControlador
    {
        Sentencias sn = new Sentencias();

        public void llenartablaa(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }



        }


    }
}