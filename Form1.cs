using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAlumnos
{
    public partial class Form1 : Form
    {
        List<Alumnos> listaAlumnos;
        public Form1()
        {
            InitializeComponent();

            listaAlumnos = new List<Alumnos>();
            dgvNotas.AutoGenerateColumns = false;
        }

        //Inicio de la clase Alumnos
        public class Alumnos
        {
            // Atributos o campos
            private string _dni = "";
            private string _nombre = "";
            private decimal _notaMate;
            private decimal _notaLengua;
            private decimal _notaFisica;

            // Propiedades            
            public string DNI
            {
                get
                {
                    return _dni;
                }
                set
                {
                    value = value.Trim();

                    if (!string.IsNullOrWhiteSpace(value)
                        && value.Length >= 6
                        && value.Length <= 8
                        && value.All(char.IsDigit))
                    {
                        _dni = value;
                    }
                }
            }

            public string Nombre
            {
                get
                {
                    return _nombre;
                }
                set
                {
                    value = value.Trim();

                    if (!string.IsNullOrWhiteSpace(value)
                        && value.Length >= 3
                        && value.Length <= 15
                        && value.All(c => char.IsLetter(c) || c == ' '))
                    {
                        _nombre = value.ToUpper();
                    }
                }
            }


            public decimal NotaMate
            {
                get
                {
                    return _notaMate;
                }
                set
                {
                    if (value >= 0 && value <= 10)
                    {
                        _notaMate = value;
                    }
                }
            }

            public decimal NotaLengua
            {
                get
                {
                    return _notaLengua;
                }
                set
                {
                    if (value >= 0 && value <= 10)
                    {
                        _notaLengua = value;
                    }
                }
            }

            public decimal NotaFisica
            {
                get
                {
                    return _notaFisica;
                }
                set
                {
                    if (value >= 0 && value <= 10)
                    {
                        _notaFisica = value;
                    }
                }
            }



            //Agrego propiedades de solo lectura al solo efecto se muestren en el DataGridVieu usando DataSource
            public decimal Promedio
            {
                get
                {
                    return Math.Round(PromediarNotas(), 2);
                }
            }


            public string Condicion
            {
                get
                {
                    return ObtenerCondicion();
                }
            }


            // Constructor
            public Alumnos(
                string dni,
                string nombre,
                decimal notaMate,
                decimal notaLengua,
                decimal notaFisica)
            {
                DNI = dni;
                Nombre = nombre;
                NotaMate = notaMate;
                NotaLengua = notaLengua;
                NotaFisica = notaFisica;
            }

            // Métodos
            public decimal PromediarNotas()
            {
                decimal suma = _notaMate + _notaLengua + _notaFisica;
                decimal promedio = suma / 3;

                return promedio;
            }

            public string ObtenerCondicion()
            {
                decimal promedio = PromediarNotas();

                if (promedio <= 4)
                {
                    return "Desaprobado";
                }

                if (promedio <= 6)
                {
                    return "Regular";
                }

                return "Aprobado";
            }

        }
        //Fin de la clase Alumnos


        //validacion de los valores que ingresa el usuario
        private void button1_Click(object sender, EventArgs e)
        {
            string dniIngresado = txtDni.Text.Trim();
            if (!dniIngresado.All(char.IsDigit) || dniIngresado.Length != 8)
            {
                MessageBox.Show("El DNI debe contener ocho dígitos numéricos.");
                txtDni.Focus();
                return;
            }

            string nombreIngresado = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreIngresado) ||
            nombreIngresado.Length < 3 ||
            nombreIngresado.Length > 15 ||
            !nombreIngresado.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Nombre no válido...");
                txtNombre.Focus();
                return;
            }
            decimal notaMatematicaIngresada;
            decimal notaLenguajeIngresada;
            decimal notaFisicaIngresada;

            if (!decimal.TryParse(txtNotaMatematica.Text, out notaMatematicaIngresada))
            {
                MessageBox.Show("Nota de Matemática inválida.");
                return;
            }

            if (!decimal.TryParse(txtNotaLenguaje.Text, out notaLenguajeIngresada))
            {
                MessageBox.Show("Nota de Lengua inválida.");
                return;
            }

            if (!decimal.TryParse(txtNotaFisica.Text, out notaFisicaIngresada))
            {
                MessageBox.Show("Nota de Física inválida.");
                return;
            }

            //creo un objeto con los valores ingresados en los campos
            Alumnos alumno1 = new Alumnos(dniIngresado, nombreIngresado, notaMatematicaIngresada, notaLenguajeIngresada, notaFisicaIngresada);
            
            //agrego el objeto a la lista
            listaAlumnos.Add(alumno1);

            //lamo al método que muestra los datos en la grilla
            mostrarDatosEnGrilla();

            //llamo al método limpiar campos
            limpiarCampos();

        }
        
        
        //método que ustiliza la propiedad DataSource, en la cual trae los valores de las propiedades del objeto
        public void mostrarDatosEnGrilla()
        {
            dgvNotas.DataSource = null;
            dgvNotas.DataSource = listaAlumnos;

        }

        //método que limpia los campos y luego focaliza el cursor en dni
        public void limpiarCampos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtNotaMatematica.Clear();
            txtNotaLenguaje.Clear();
            txtNotaFisica.Clear();
            txtDni.Focus();
        }
        
        //método eliminar un registro
          private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = dgvNotas.CurrentRow.Index;

            DialogResult respuesta = MessageBox.Show(
                "¿Eliminar alumno?",
                "Confirmación",
                MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                listaAlumnos.RemoveAt(i);
                mostrarDatosEnGrilla();
            }
        }


        //método salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del programa?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }







    }
}
