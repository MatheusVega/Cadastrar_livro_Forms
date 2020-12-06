using Books.DAL;
using Books.Model;
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
            textID.Enabled = false;
            textAutor.Enabled = false;
            textDescricao.Enabled = false;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            comboNota.Enabled = false;



        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            textID.Enabled = true;
            textAutor.Enabled = true;
            textDescricao.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            comboNota.Enabled = true;
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
            SalvarDadosEntity();
            textNome.Text = "";
            textAutor.Text = "";
            textDescricao.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            comboNota.Text = "";
            textNome.Text = "";


        }
        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            preencherTelaEntity();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            TotalLivro();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //excluir
        }

        public void ExcluirDadoEntity()
        {
            using (var contexto = new LivroDal())
            {
                IList<Livro> livros = contexto.Preencher();
                foreach (var item in livros)
                {
                    contexto.Excluir(item);
                }
            }
        }

        public void SalvarDados()
        {
            try
            {
                var update = "INSERT INTO TB_LIVRO (LVR_NOME, LVR_AUTOR, LVR_DESCRICAO, LVR_DATA_INICIO, LVR_DATA_FIM, LVR_TIPO, LVR_NOTA)" +
                                "VALUES ('" + sgNome + "','" + sgAutor + "','" + sgDescricao + "','" + sgDataInicio + "','" + sgDataFinal + "','" + sgTipo + "','" + sgNota + "')";
                Conn.ComandoSql(update);
                MessageBox.Show("Finalizado");
            }
            catch
            {
                MessageBox.Show("Erro ao Salvar Dado");
            }
            

        }
        public void SalvarDadosEntity()
        {
            try
            {
                Livro l = new Livro();

                l.Nome = sgNome;
                l.Autor = sgAutor;
                l.Descricao = sgDescricao;
                l.DataIncicio = sgDataInicio;
                l.DataFim = sgDataFinal;
                l.Tipo = sgTipo;
                l.Nota = sgNota;



                using (var contexto = new LivroDal())
                {
                    contexto.Salvar(l);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao Salvar Dado");
            }


        }
        public void preencherTela()
        {
            var sql = "SELECT * FROM TB_LIVRO WHERE LVR_NOME LIKE '"+sgNome+"%'";

            DataTable dt = Conn.ComandoSqlDt(sql);

            foreach (DataRow dr in dt.Rows)
            {
                textID.Text = dr["LVR_ID"].ToString().TrimEnd();
                textNome.Text = dr["LVR_NOME"].ToString().TrimEnd();
                textAutor.Text = dr["LVR_AUTOR"].ToString().TrimEnd();
                textDescricao.Text = dr["LVR_DESCRICAO"].ToString().TrimEnd();
                maskedTextBox1.Text = dr["LVR_DATA_INICIO"].ToString().TrimEnd();
                maskedTextBox2.Text = dr["LVR_DATA_FIM"].ToString().TrimEnd();
                comboNota.Text = dr["LVR_NOTA"].ToString().TrimEnd();
                if (dr["LVR_TIPO"].ToString().TrimEnd() == "Fisico")
                {
                    checkFisico.Checked = true;
                    
                }
                if (dr["LVR_TIPO"].ToString().TrimEnd() == "Virtual")
                {
                    checkVirtual.Checked = true;
                    
                }

            }
           

        }
        public void preencherTelaEntity()
        {
            using(var contexto = new LivroDal())
            {
                IList<Livro> livros = contexto.Preencher();
                foreach(var item in livros)
                {
                    textID.Text = item.Id.ToString();
                    textNome.Text = item.Nome;
                    textAutor.Text = item.Autor;
                    textDescricao.Text = item.Descricao;
                    maskedTextBox1.Text = item.DataIncicio;
                    maskedTextBox2.Text = item.DataFim;
                    comboNota.Text = item.Nota ;
                    if (item.Tipo == "Fisico")
                    {
                        checkFisico.Checked = true;

                    }
                    if (item.Tipo == "Virtual")
                    {
                        checkVirtual.Checked = true;

                    }
                }
            }
        }

        public void TotalLivro()
        {
            var sql =   "SELECT COUNT(*) AS TOTAL FROM TB_LIVRO " +
                        "WHERE LVR_DATA_FIM >= '"+ maskedTextBox1.Text +"'"+
                        "AND LVR_DATA_FIM <= '"+ maskedTextBox2.Text + "'";

            DataTable dt = Conn.ComandoSqlDt(sql);

            foreach (DataRow dr in dt.Rows)
            {
                textQuant.Text = dr["TOTAL"].ToString().TrimEnd();
            }


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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       
    }
}
