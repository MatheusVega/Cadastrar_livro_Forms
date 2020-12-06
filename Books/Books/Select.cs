using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class Cadastrar : Form
    {
        ClsConexao Conn = new ClsConexao();
        public string sgNome = "";
        public string sgAutor = "";
        public string sgDescricao = "";
        public string sgDataInicio = "";
        public string sgDataFinal = "";
        public string sgNota = "";
        public string sgTipo = "";


        public Cadastrar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conn.Conectar();
            comboNota.Items.Add("Ruim");
            comboNota.Items.Add("Éeeeeeeee");
            comboNota.Items.Add("Mais ou Menos");
            comboNota.Items.Add("Bom, mas né");
            comboNota.Items.Add("Maravilhoso, mas crespuculo é melhor!!!");
            comboNota.Items.Add("Me deixou em dúvida");


        }
        private void button1_Click(object sender, EventArgs e)
        {

            sgNome = textNome.Text;
            sgAutor = textAutor.Text;
            sgDescricao = textDescricao.Text;
            sgDataInicio = maskedTextBox1.Text;
            sgDataFinal = maskedTextBox2.Text;
            sgNota = comboNota.Text;
            sgTipo = textNome.Text ;
            if (checkFisico.Checked == true)
            {
                sgTipo = "Fisico";
            }
            if(checkVirtual.Checked == true)
            {
                sgTipo = "Virtual";
            }
            SalvarDados();

        }
        public void SalvarDados()
        {
          
            var update = "INSERT INTO TB_LIVRO (LVR_NOME, LVR_AUTOR, LVR_DESCRICAO, LVR_DATA_INICIO, LVR_DATA_FIM, LVR_TIPO, LVR_NOTA)" +
                "VALUES ('" + sgNome + "','" + sgAutor + "','" + sgDescricao + "','" + sgDataInicio + "','" + sgDataFinal + "','" + sgTipo + "','" + sgNota + "')";
            Conn.ComandoSql(update);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
