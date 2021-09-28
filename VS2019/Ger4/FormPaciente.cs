
using System;
using System.Data;
using System.Windows.Forms;
using capaENT;
using capaNEG;

namespace Ger4
{
    public partial class FormPaciente : Form
    {
        public FormPaciente() { InitializeComponent(); }

        public perENT tt = new perENT();
        public pacENT xx = new pacENT();
        public capaLogica zz = new capaLogica();

        private void FormPaciente_Load(object sender, EventArgs e){
            cargPerson();
            cargLugr();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            textBox1.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            int vartt, indice;
            ds = zz.listar();
            vartt = ds.Tables[0].Rows.Count - 1;

            for (indice = 0; indice <= vartt; indice++)
            {
                object dni = ds.Tables[0].Rows[indice][0].ToString();
                object nombre = ds.Tables[0].Rows[indice][1].ToString();
                object apellido = ds.Tables[0].Rows[indice][2].ToString();
                object fecha = ds.Tables[0].Rows[indice][3].ToString();
                object obsocial = ds.Tables[0].Rows[indice][4].ToString();
                object foto = ds.Tables[0].Rows[indice][5].ToString();

                dgvPac.Rows.Add(dni, nombre, apellido, fecha, obsocial, foto);
            }
        } 
        
        public void btnAgregar_Click(object sender, EventArgs e)
        {
            try{
                xx.Documento = Convert.ToInt32(textBox1.Text);
                xx.Nombre = textBox2.Text;
                xx.Apellido = textBox3.Text;
                xx.Fecha = dateTimePicker1.Value;
                xx.Obrsocial = comboBox1.Text;
                xx.Foto = pictureBox1.ImageLocation;

                zz.llevare(ref xx);

            }
            catch{ MessageBox.Show("Error"); }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fot = new OpenFileDialog();
            fot.Filter = "Tipo de archivo (*.jpg)|*.jpg| file type  (*.png)|*.png | all files (*.*) | *.*" ;
            fot.ShowDialog();
            pictureBox1.ImageLocation = fot.FileName;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, doc, obsocial, fecha, foto;
          
            nombre = textBox2.Text;
            doc = textBox1.Text;
            apellido = textBox3.Text;
            fecha = dateTimePicker1.Text;
            obsocial = comboBox1.Text;
            foto = pictureBox1.ImageLocation;
            // SE AGREGAN EN LAS COLUMNAS SEGUN EL ORDEN 
            dgvPac.Rows.Add(doc, nombre, apellido, fecha, obsocial, foto);

        }

        public void cargPerson()
        {
            comboBox3.DataSource = zz.cargarPersonal();
            comboBox3.DisplayMember = "anfitriones";
        }

        public void cargLugr()
        {
            comboBox4.DataSource = zz.cargarLugar();
            comboBox4.DisplayMember = "lugares";
            // comboBox2.ValueMember = "lugar";
        }

        private void btnGuardarVisitas_Click(object sender, EventArgs e)
        {
            try{
                tt.Documento = Convert.ToInt32(textBox6.Text);
                tt.Nombre = textBox5.Text;
                tt.Parentezco = comboBox2.Text;
                tt.Anfitrion = comboBox3.Text;
                tt.Salon = comboBox4.Text;

                zz.llevar_visita(ref tt);
            }
            catch { MessageBox.Show("Erroor"); }
        }

        #region VALIDACION DE textBox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) // para que la 'Key' presionada este controlada
                && !char.IsDigit(e.KeyChar)) // para que la key solo sea digito
            { e.Handled = true; }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) // para que la 'Key' presionada este controlada
                && !char.IsDigit(e.KeyChar)) // para que la key solo sea digito
            { e.Handled = true; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsLetter(e.KeyChar))
            { e.Handled = true; }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
              && !char.IsLetter(e.KeyChar))
            { e.Handled = true; }
        }

        #endregion

    }
}


