using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Superliga
{
    public partial class Usuarios : Form
    {
        public List<Entidades.Usuario> lUsuario = new List<Entidades.Usuario>();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            string ruta;
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Archivos csv (*.csv)|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtRuta.Text = openFileDialog1.FileName;
                    ruta = txtRuta.Text;

                    lUsuario = Negocio.Usuario.consultaTodos(ruta);

                    if (lUsuario != null && lUsuario.Count > 0)
                    {

                        #region Cantidad personas registradas

                        int cantidadPersReg = lUsuario.Count;
                        txtCantReg.Text = cantidadPersReg.ToString();

                        #endregion

                        #region Promedio Edad Socios Racing
                        int cantRacing = 0;
                        decimal promEdadRac = 0;
                        foreach (Entidades.Usuario oUsuario in lUsuario)
                        {
                            if (oUsuario.equipo == "Racing")
                            {
                                cantRacing++;
                                promEdadRac += oUsuario.edad;
                            }
                        }

                        promEdadRac = Math.Round(promEdadRac / cantRacing, 2);

                        txtPromEdadRacing.Text = promEdadRac.ToString();

                        #endregion

                        #region 100 primeras personas casadas y con estudios universitarios


                        List<Entidades.Usuario> lUsuarioA = new List<Entidades.Usuario>();
                        foreach (Entidades.Usuario oUsuario in lUsuario)
                        {
                            if (oUsuario.estadoCivil == "Casado" && oUsuario.nivelEstudio == "Universitario")
                            {
                                lUsuarioA.Add(oUsuario);
                                if (lUsuarioA.Count == 100)
                                    break;
                            }
                        }

                        lUsuarioA = lUsuarioA.OrderBy(x => x.edad).ToList();


                        dgvCasUniv.Rows.Clear();
                        dgvCasUniv.DataSource = lUsuarioA;

                        lUsuarioA = null;

                        #endregion

                        #region Los 5 nombres mas comunes entre los hinchas de river

                        List<Entidades.UsuarioAux> lUsuarioAux = new List<Entidades.UsuarioAux>();

                        foreach (Entidades.Usuario oUsuario in lUsuario)
                        {
                            if (oUsuario.equipo == "River")
                            {

                                if (lUsuarioAux.Exists(x => x.nombre == oUsuario.nombre))
                                {
                                    Entidades.UsuarioAux oUsuarioAux = lUsuarioAux.Find(x => x.nombre == oUsuario.nombre);
                                    oUsuarioAux.cantidad++;
                                }
                                else
                                {
                                    Entidades.UsuarioAux oUsuarioAux = new Entidades.UsuarioAux();
                                    oUsuarioAux.nombre = oUsuario.nombre;
                                    oUsuarioAux.cantidad = 1;
                                    lUsuarioAux.Add(oUsuarioAux);
                                }
                            }

                        }

                        lUsuarioAux = lUsuarioAux.OrderByDescending(x => x.cantidad).ToList();
                        lUsuarioAux.RemoveRange(5, lUsuarioAux.Count - 5);

                        cmbHinchasRiver.DataSource = lUsuarioAux;
                        cmbHinchasRiver.DisplayMember = "nombre";

                        #endregion

                        #region Listado de clubes segun cantidad socios, etc etc etc

                        List<Entidades.clubes> lClubes = new List<Entidades.clubes>();
                        foreach (Entidades.Usuario oUsuario in lUsuario)
                        {
                            if (lClubes.Exists(x => x.equipo == oUsuario.equipo))
                            {
                                Entidades.clubes oClubes = lClubes.Find(x => x.equipo == oUsuario.equipo);
                                oClubes.cantidadSocios++;
                                oClubes.promedioEdad += oUsuario.edad;

                                if (oUsuario.edad > oClubes.mayorEdad)
                                    oClubes.mayorEdad = oUsuario.edad;

                                if (oUsuario.edad < oClubes.menorEdad)
                                    oClubes.menorEdad = oUsuario.edad;
                            }
                            else
                            {
                                Entidades.clubes oClubes = new Entidades.clubes();
                                oClubes.equipo = oUsuario.equipo;
                                oClubes.cantidadSocios = 1;
                                oClubes.promedioEdad += oUsuario.edad;
                                oClubes.mayorEdad = oUsuario.edad;
                                oClubes.menorEdad = oUsuario.edad;

                                lClubes.Add(oClubes);
                            }
                        }

                        foreach (Entidades.clubes oClubes in lClubes)
                        {
                            oClubes.promedioEdad = Math.Round(oClubes.promedioEdad / oClubes.cantidadSocios, 2);
                        }

                        lClubes = lClubes.OrderByDescending(x => x.cantidadSocios).ToList();

                        dtgClubes.Rows.Clear();
                        dtgClubes.DataSource = lClubes;


                        #endregion


                    }
                    else
                    {
                        MessageBox.Show("Archivo vacío");
                    }


                }
                catch(Exception ex)
                {
                    throw ex;
                }

            }
        }

    }
}
