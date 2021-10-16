using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Superliga
{
    public class Datos
    {
        public class Usuario
        {
            public static List<Entidades.Usuario> consultaTodos(string path)
            {
                List<Entidades.Usuario> lUsuarios = new List<Entidades.Usuario>();
                try
                {
                    DataTable dtXLS = new DataTable();
                    string strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0;HDR=No;IMEX=1\";", path);//"c:/recursiva/socios.csv");
                    OleDbConnection SQLConn = new OleDbConnection(strConnectionString);
                    SQLConn.Open();
                    OleDbDataAdapter SQLAdapter = new OleDbDataAdapter();
                    string sql = "SELECT * FROM [socios$]";
                    OleDbCommand selectCMD = new OleDbCommand(sql, SQLConn);
                    SQLAdapter.SelectCommand = selectCMD;

                    SQLAdapter.Fill(dtXLS);
                    SQLConn.Close();

                    foreach (DataRow row in dtXLS.Rows)
                    {
                        int iAux = 0;
                        Entidades.Usuario oUsuario = new Entidades.Usuario();
                        oUsuario.nombre = row[0].ToString();
                        int.TryParse(row[1].ToString(), out iAux);
                        oUsuario.edad = iAux;
                        oUsuario.equipo = row[2].ToString();
                        oUsuario.estadoCivil = row[3].ToString();
                        oUsuario.nivelEstudio = row[4].ToString();

                        lUsuarios.Add(oUsuario);
                    }

                    return lUsuarios;
                }
                catch
                {
                    return null;
                }
            }

            

        }
    }
}
