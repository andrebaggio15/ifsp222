namespace WinFormsApp1
{
    partial class FormCadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAluno));
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            FomrCadastroAluno = new TabPage();
            materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            materialMaskedTextBox7 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            materialMaskedTextBox6 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox5 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox4 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox3 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox2 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox1 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabPage2 = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            FomrCadastroAluno.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(FomrCadastroAluno);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(603, 428);
            materialTabControl1.TabIndex = 0;
            materialTabControl1.SelectedIndexChanged += materialTabControl1_SelectedIndexChanged;
            // 
            // FomrCadastroAluno
            // 
            FomrCadastroAluno.Controls.Add(materialButton2);
            FomrCadastroAluno.Controls.Add(materialButton1);
            FomrCadastroAluno.Controls.Add(materialMaskedTextBox7);
            FomrCadastroAluno.Controls.Add(materialComboBox1);
            FomrCadastroAluno.Controls.Add(materialMaskedTextBox6);
            FomrCadastroAluno.Controls.Add(materialMaskedTextBox5);
            FomrCadastroAluno.Controls.Add(materialMaskedTextBox4);
            FomrCadastroAluno.Controls.Add(materialMaskedTextBox3);
            FomrCadastroAluno.Controls.Add(materialMaskedTextBox2);
            FomrCadastroAluno.Controls.Add(materialMaskedTextBox1);
            FomrCadastroAluno.ImageKey = "form.png";
            FomrCadastroAluno.Location = new Point(4, 31);
            FomrCadastroAluno.Name = "FomrCadastroAluno";
            FomrCadastroAluno.Padding = new Padding(3);
            FomrCadastroAluno.Size = new Size(595, 393);
            FomrCadastroAluno.TabIndex = 0;
            FomrCadastroAluno.Text = "Cadastro";
            FomrCadastroAluno.UseVisualStyleBackColor = true;
            FomrCadastroAluno.Click += tabPage1_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton2.Location = new Point(512, 348);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(76, 36);
            materialButton2.TabIndex = 10;
            materialButton2.Text = "Salvar";
            materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(392, 348);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(96, 36);
            materialButton1.TabIndex = 9;
            materialButton1.Text = "Cancelar";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialMaskedTextBox7
            // 
            materialMaskedTextBox7.AllowPromptAsInput = true;
            materialMaskedTextBox7.AnimateReadOnly = false;
            materialMaskedTextBox7.AsciiOnly = false;
            materialMaskedTextBox7.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox7.BeepOnError = false;
            materialMaskedTextBox7.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox7.Depth = 0;
            materialMaskedTextBox7.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox7.HidePromptOnLeave = false;
            materialMaskedTextBox7.HideSelection = true;
            materialMaskedTextBox7.Hint = "Senha";
            materialMaskedTextBox7.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox7.LeadingIcon = Properties.Resources.baseline_fingerprint_black_24dp;
            materialMaskedTextBox7.Location = new Point(3, 284);
            materialMaskedTextBox7.Mask = "";
            materialMaskedTextBox7.MaxLength = 32767;
            materialMaskedTextBox7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox7.Name = "materialMaskedTextBox7";
            materialMaskedTextBox7.PasswordChar = '●';
            materialMaskedTextBox7.PrefixSuffixText = null;
            materialMaskedTextBox7.PromptChar = '_';
            materialMaskedTextBox7.ReadOnly = false;
            materialMaskedTextBox7.RejectInputOnFirstFailure = false;
            materialMaskedTextBox7.ResetOnPrompt = true;
            materialMaskedTextBox7.ResetOnSpace = true;
            materialMaskedTextBox7.RightToLeft = RightToLeft.No;
            materialMaskedTextBox7.SelectedText = "";
            materialMaskedTextBox7.SelectionLength = 0;
            materialMaskedTextBox7.SelectionStart = 0;
            materialMaskedTextBox7.ShortcutsEnabled = true;
            materialMaskedTextBox7.Size = new Size(587, 48);
            materialMaskedTextBox7.SkipLiterals = true;
            materialMaskedTextBox7.TabIndex = 8;
            materialMaskedTextBox7.TabStop = false;
            materialMaskedTextBox7.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox7.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox7.TrailingIcon = null;
            materialMaskedTextBox7.UseSystemPasswordChar = true;
            materialMaskedTextBox7.ValidatingType = null;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.Hint = "Estado";
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "", "AC", "", "AL", "", "AP", "", "AM", "", "BA", "", "CE", "", "DF", "", "ES", "", "GO", "", "MA", "", "MT", "", "MS", "", "MG", "", "PA", "", "PB", "", "PR", "", "PE", "", "PI", "", "RJ", "", "RN", "", "RS", "", "RO", "", "RR", "", "SC", "", "SP", "", "SE", "", "TO" });
            materialComboBox1.Location = new Point(439, 219);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(151, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 7;
            // 
            // materialMaskedTextBox6
            // 
            materialMaskedTextBox6.AllowPromptAsInput = true;
            materialMaskedTextBox6.AnimateReadOnly = false;
            materialMaskedTextBox6.AsciiOnly = false;
            materialMaskedTextBox6.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox6.BeepOnError = false;
            materialMaskedTextBox6.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox6.Depth = 0;
            materialMaskedTextBox6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox6.HidePromptOnLeave = false;
            materialMaskedTextBox6.HideSelection = true;
            materialMaskedTextBox6.Hint = "Cidade";
            materialMaskedTextBox6.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox6.LeadingIcon = null;
            materialMaskedTextBox6.Location = new Point(3, 220);
            materialMaskedTextBox6.Mask = "";
            materialMaskedTextBox6.MaxLength = 32767;
            materialMaskedTextBox6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox6.Name = "materialMaskedTextBox6";
            materialMaskedTextBox6.PasswordChar = '\0';
            materialMaskedTextBox6.PrefixSuffixText = null;
            materialMaskedTextBox6.PromptChar = '_';
            materialMaskedTextBox6.ReadOnly = false;
            materialMaskedTextBox6.RejectInputOnFirstFailure = false;
            materialMaskedTextBox6.ResetOnPrompt = true;
            materialMaskedTextBox6.ResetOnSpace = true;
            materialMaskedTextBox6.RightToLeft = RightToLeft.No;
            materialMaskedTextBox6.SelectedText = "";
            materialMaskedTextBox6.SelectionLength = 0;
            materialMaskedTextBox6.SelectionStart = 0;
            materialMaskedTextBox6.ShortcutsEnabled = true;
            materialMaskedTextBox6.Size = new Size(421, 48);
            materialMaskedTextBox6.SkipLiterals = true;
            materialMaskedTextBox6.TabIndex = 6;
            materialMaskedTextBox6.TabStop = false;
            materialMaskedTextBox6.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox6.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox6.TrailingIcon = null;
            materialMaskedTextBox6.UseSystemPasswordChar = false;
            materialMaskedTextBox6.ValidatingType = null;
            // 
            // materialMaskedTextBox5
            // 
            materialMaskedTextBox5.AllowPromptAsInput = true;
            materialMaskedTextBox5.AnimateReadOnly = false;
            materialMaskedTextBox5.AsciiOnly = false;
            materialMaskedTextBox5.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox5.BeepOnError = false;
            materialMaskedTextBox5.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox5.Depth = 0;
            materialMaskedTextBox5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox5.HidePromptOnLeave = false;
            materialMaskedTextBox5.HideSelection = true;
            materialMaskedTextBox5.Hint = "Bairro";
            materialMaskedTextBox5.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox5.LeadingIcon = null;
            materialMaskedTextBox5.Location = new Point(3, 165);
            materialMaskedTextBox5.Mask = "";
            materialMaskedTextBox5.MaxLength = 32767;
            materialMaskedTextBox5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox5.Name = "materialMaskedTextBox5";
            materialMaskedTextBox5.PasswordChar = '\0';
            materialMaskedTextBox5.PrefixSuffixText = null;
            materialMaskedTextBox5.PromptChar = '_';
            materialMaskedTextBox5.ReadOnly = false;
            materialMaskedTextBox5.RejectInputOnFirstFailure = false;
            materialMaskedTextBox5.ResetOnPrompt = true;
            materialMaskedTextBox5.ResetOnSpace = true;
            materialMaskedTextBox5.RightToLeft = RightToLeft.No;
            materialMaskedTextBox5.SelectedText = "";
            materialMaskedTextBox5.SelectionLength = 0;
            materialMaskedTextBox5.SelectionStart = 0;
            materialMaskedTextBox5.ShortcutsEnabled = true;
            materialMaskedTextBox5.Size = new Size(587, 48);
            materialMaskedTextBox5.SkipLiterals = true;
            materialMaskedTextBox5.TabIndex = 5;
            materialMaskedTextBox5.TabStop = false;
            materialMaskedTextBox5.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox5.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox5.TrailingIcon = null;
            materialMaskedTextBox5.UseSystemPasswordChar = false;
            materialMaskedTextBox5.ValidatingType = null;
            // 
            // materialMaskedTextBox4
            // 
            materialMaskedTextBox4.AllowPromptAsInput = true;
            materialMaskedTextBox4.AnimateReadOnly = false;
            materialMaskedTextBox4.AsciiOnly = false;
            materialMaskedTextBox4.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox4.BeepOnError = false;
            materialMaskedTextBox4.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox4.Depth = 0;
            materialMaskedTextBox4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox4.HidePromptOnLeave = false;
            materialMaskedTextBox4.HideSelection = true;
            materialMaskedTextBox4.Hint = "Endereço";
            materialMaskedTextBox4.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox4.LeadingIcon = null;
            materialMaskedTextBox4.Location = new Point(3, 111);
            materialMaskedTextBox4.Mask = "";
            materialMaskedTextBox4.MaxLength = 32767;
            materialMaskedTextBox4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox4.Name = "materialMaskedTextBox4";
            materialMaskedTextBox4.PasswordChar = '\0';
            materialMaskedTextBox4.PrefixSuffixText = null;
            materialMaskedTextBox4.PromptChar = '_';
            materialMaskedTextBox4.ReadOnly = false;
            materialMaskedTextBox4.RejectInputOnFirstFailure = false;
            materialMaskedTextBox4.ResetOnPrompt = true;
            materialMaskedTextBox4.ResetOnSpace = true;
            materialMaskedTextBox4.RightToLeft = RightToLeft.No;
            materialMaskedTextBox4.SelectedText = "";
            materialMaskedTextBox4.SelectionLength = 0;
            materialMaskedTextBox4.SelectionStart = 0;
            materialMaskedTextBox4.ShortcutsEnabled = true;
            materialMaskedTextBox4.Size = new Size(587, 48);
            materialMaskedTextBox4.SkipLiterals = true;
            materialMaskedTextBox4.TabIndex = 4;
            materialMaskedTextBox4.TabStop = false;
            materialMaskedTextBox4.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox4.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox4.TrailingIcon = null;
            materialMaskedTextBox4.UseSystemPasswordChar = false;
            materialMaskedTextBox4.ValidatingType = null;
            // 
            // materialMaskedTextBox3
            // 
            materialMaskedTextBox3.AllowPromptAsInput = true;
            materialMaskedTextBox3.AnimateReadOnly = false;
            materialMaskedTextBox3.AsciiOnly = false;
            materialMaskedTextBox3.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox3.BeepOnError = false;
            materialMaskedTextBox3.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox3.Depth = 0;
            materialMaskedTextBox3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox3.HidePromptOnLeave = false;
            materialMaskedTextBox3.HideSelection = true;
            materialMaskedTextBox3.Hint = "Data Nascimento";
            materialMaskedTextBox3.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox3.LeadingIcon = null;
            materialMaskedTextBox3.Location = new Point(310, 3);
            materialMaskedTextBox3.Mask = "99/99/9999";
            materialMaskedTextBox3.MaxLength = 32767;
            materialMaskedTextBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox3.Name = "materialMaskedTextBox3";
            materialMaskedTextBox3.PasswordChar = '\0';
            materialMaskedTextBox3.PrefixSuffixText = null;
            materialMaskedTextBox3.PromptChar = '_';
            materialMaskedTextBox3.ReadOnly = false;
            materialMaskedTextBox3.RejectInputOnFirstFailure = false;
            materialMaskedTextBox3.ResetOnPrompt = true;
            materialMaskedTextBox3.ResetOnSpace = true;
            materialMaskedTextBox3.RightToLeft = RightToLeft.No;
            materialMaskedTextBox3.SelectedText = "";
            materialMaskedTextBox3.SelectionLength = 0;
            materialMaskedTextBox3.SelectionStart = 0;
            materialMaskedTextBox3.ShortcutsEnabled = true;
            materialMaskedTextBox3.Size = new Size(280, 48);
            materialMaskedTextBox3.SkipLiterals = true;
            materialMaskedTextBox3.TabIndex = 3;
            materialMaskedTextBox3.TabStop = false;
            materialMaskedTextBox3.Text = "  /  /";
            materialMaskedTextBox3.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox3.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox3.TrailingIcon = null;
            materialMaskedTextBox3.UseSystemPasswordChar = false;
            materialMaskedTextBox3.ValidatingType = null;
            // 
            // materialMaskedTextBox2
            // 
            materialMaskedTextBox2.AllowPromptAsInput = true;
            materialMaskedTextBox2.AnimateReadOnly = false;
            materialMaskedTextBox2.AsciiOnly = false;
            materialMaskedTextBox2.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox2.BeepOnError = false;
            materialMaskedTextBox2.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.Depth = 0;
            materialMaskedTextBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox2.HidePromptOnLeave = false;
            materialMaskedTextBox2.HideSelection = true;
            materialMaskedTextBox2.Hint = "Nome";
            materialMaskedTextBox2.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox2.LeadingIcon = null;
            materialMaskedTextBox2.Location = new Point(6, 57);
            materialMaskedTextBox2.Mask = "";
            materialMaskedTextBox2.MaxLength = 32767;
            materialMaskedTextBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox2.Name = "materialMaskedTextBox2";
            materialMaskedTextBox2.PasswordChar = '\0';
            materialMaskedTextBox2.PrefixSuffixText = null;
            materialMaskedTextBox2.PromptChar = '_';
            materialMaskedTextBox2.ReadOnly = false;
            materialMaskedTextBox2.RejectInputOnFirstFailure = false;
            materialMaskedTextBox2.ResetOnPrompt = true;
            materialMaskedTextBox2.ResetOnSpace = true;
            materialMaskedTextBox2.RightToLeft = RightToLeft.No;
            materialMaskedTextBox2.SelectedText = "";
            materialMaskedTextBox2.SelectionLength = 0;
            materialMaskedTextBox2.SelectionStart = 0;
            materialMaskedTextBox2.ShortcutsEnabled = true;
            materialMaskedTextBox2.Size = new Size(587, 48);
            materialMaskedTextBox2.SkipLiterals = true;
            materialMaskedTextBox2.TabIndex = 2;
            materialMaskedTextBox2.TabStop = false;
            materialMaskedTextBox2.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox2.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.TrailingIcon = null;
            materialMaskedTextBox2.UseSystemPasswordChar = false;
            materialMaskedTextBox2.ValidatingType = null;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.Hint = "Matricula";
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(3, 3);
            materialMaskedTextBox1.Mask = "";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(292, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 0;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            materialMaskedTextBox1.Click += materialMaskedTextBox1_Click;
            // 
            // tabPage2
            // 
            tabPage2.ImageKey = "search.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(595, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "search.png");
            imageList1.Images.SetKeyName(1, "form.png");
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 495);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "FormCadastroAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            Load += FormCadastroAluno_Load;
            materialTabControl1.ResumeLayout(false);
            FomrCadastroAluno.ResumeLayout(false);
            FomrCadastroAluno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage FomrCadastroAluno;
        private TabPage tabPage2;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox3;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox2;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox6;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox5;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox4;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox7;
    }
}