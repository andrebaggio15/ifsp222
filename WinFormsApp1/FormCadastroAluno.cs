using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Drawing.Text;


namespace WinFormsApp1
{
    public partial class FormCadastroAluno : MaterialForm
    {
        string alunosFileName = "alunos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;
        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if(ValidaFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
            }
        }
        private bool ValidaFormulario()
        {
            if(string.IsNullOrEmpty(materialMaskedTextBox1.Text))
            {
                MessageBox.Show("Matricula Obgrigatoria!","IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialMaskedTextBox1.Focus();
                return false;
            }

            if (!DateTime.TryParse(materialMaskedTextBox3.Text, out DateTime ))
            {
                MessageBox.Show("Data de Nascimento Invalida!","IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialMaskedTextBox3.Focus();
                return false;
            }
            return true;

            if (string.IsNullOrEmpty(materialMaskedTextBox3.Text))
            {
                MessageBox.Show("Nome Obgrigatorio!","IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialMaskedTextBox3.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(materialMaskedTextBox2.Text))
            {
                MessageBox.Show("Endereço Obgrigatorio!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialMaskedTextBox2.Focus();
                return false;
            }

        }
        private void Salvar()
        {
            var line = $"{materialMaskedTextBox1};" +
                       $"{materialMaskedTextBox3};" +
                       $"{materialMaskedTextBox2};" +
                       $"{materialMaskedTextBox4};" +
                       $"{materialMaskedTextBox5};" +
                       $"{materialMaskedTextBox6};" +
                       $"{materialComboBox1};" +
                       $"{materialMaskedTextBox7};";
            if (!isAlteracao)
            {
                var file = new StreamWriter(alunosFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else
            {

            }
            LimpaCampos()
            }

        private void LimpaCapmpos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MasterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }


            }
}
