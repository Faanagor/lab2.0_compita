using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace app_test_example
{
    public partial class Form1 : Form
    {
        private string hoja;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LLenarGrid(string archivo, string hoja)
        {
            //declaramos las variables         
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";

            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            //string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion                    
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                    dataGridView1.AllowUserToAddRows = true;
                    dataGridView1.AllowUserToDeleteRows = true;     //la ultima fila del datagridview se autoelimina
                    dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
                    
                    dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet                    
                                                                  //dataGridView1.AllowUserToAddRows = true;       //la ultima fila del datagridview se autoagrega
                    //dataGridView1.Columns.Add(dataGridView1.Columns[7]);
                    //dataGridView1.Columns.Add(dataGridView1.Columns[7]);
                    dataGridView1.Columns.Remove("Formato_busqueda");
                    dataGridView1.Columns.Remove("nombre_elemento");
                    dataGridView1.Columns.Remove("nombre_variable");
                    dataGridView1.Columns.Remove("tipo_elemento");
                    dataGridView1.Columns.Remove("componente");
                    dataGridView1.Columns.Remove("orden_ejecucion");
                    conexion.Close();//cerramos la conexion
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {


            //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
                                                                             //solo los archivos excel

            dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

            dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

            //si al seleccionar el archivo damos Ok
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //el nombre del archivo sera asignado al textbox
                txtArchivo.Text = dialog.FileName;
                hoja = txtHoja.Text; //la variable hoja tendra el valor del textbox donde colocamos el nombre de la hoja
                //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                LLenarGrid(txtArchivo.Text, hoja); //se manda a llamar al metodo, en el mismo archivo que se ha abierto
                actualizarButton.Enabled = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
            }
        }

        public void exportaraexcel(DataGridView dataGridView1)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns) //Columnas
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int indiceFila = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows) //Filas
            {
                indiceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[indiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            /*if (DataGridView.IsNullOrEmpty( dataGridView1))
            {
                MessageBox.Show("No hay datos para agregar");
            }*/

            //excel.GetSaveAsFilename();
            //excel.GetSaveAsFilename("test_probe", "Excel (*.xlsx), *.xlsx", 1, "Save TEST");


            //excel.Application.Workbooks.SaveAs();
            
            excel.Visible = true;
            string path = @"C:\Users\aguirre.fabio.andres\Documents\TEST.xlsx";
            bool request;
            if (System.IO.File.Exists(path))
            {
                request = System.IO.File.Exists(path);
                //System.out.print(request);
                //String request2 = (request);
                MessageBox.Show("Hoja de Datos guardada");
            }
            else
            {
                MessageBox.Show("Hoja de Datos No se ha guardado");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            var currentcell = dataGridView1.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            DataGridViewTextBoxCell cel = (DataGridViewTextBoxCell)dataGridView1.Rows[currentcell.Y].Cells[0];
            cel.Value = sendingCB.EditingControlFormattedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            actualizaraexcel(dataGridView1);
        }

        public void actualizaraexcel(DataGridView dataGridView1)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Open(txtArchivo.Text);

            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns) //Columnas
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int indiceFila = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows) //Filas
            {
                indiceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[indiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            //excel.GetSaveAsFilename(txtArchivo.Text);
            //excel.Visible = true;
            //excel.Workbooks.Add();
            excel.Visible = true;
            /*excel.Range["A1"].Value = "ID";
            excel.Range["B1"].Value = "USUARIO";
            excel.Range["C1"].Value = "DIRECCION";
            excel.Range["D1"].Value = "TELEFONO";
            excel.Range["E1"].Value = "EDAD";
            excel.Range["A2"].Select();*/
            MessageBox.Show("Hoja de Datos Actualizada");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarButton.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fomatoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        public void insertarFormatoBusqueda(DataGridView dataGridView1)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            
        }

        private void formatoButton_Click(object sender, EventArgs e)
        {
            insertarFormatoBusqueda(dataGridView1);
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            //this.ResetText();

            //MessageBox.Show("Hoja de Datos Cerrada");
            DialogResult result = new Form1().ShowDialog();
            if (result == DialogResult.OK) { 
            MessageBox.Show("User clicked OK");
            this.Close();
            }else if (result == DialogResult.Cancel)
                 MessageBox.Show("User clicked Cancel");
            //DialogResult result = new Form1().ShowDialog();
           /* MyDialog dialog = new Form1().MyDialog();
            dialog.ShowDialog();
            if (dialog.DialogResult.HasValue && dialog.DialogResult.Value)
                 MessageBox.Show("User clicked OK");
            else
            MessageBox.Show("User clicked Cancel");*/
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
