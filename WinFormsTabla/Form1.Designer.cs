namespace WinFormsTabla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            richTextBoxTabla = new RichTextBox();
            buttonShowTab = new Button();
            textBoxNumero = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            labelName = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(192, 192, 255);
            panelPrincipal.Controls.Add(labelName);
            panelPrincipal.Controls.Add(richTextBoxTabla);
            panelPrincipal.Controls.Add(buttonShowTab);
            panelPrincipal.Controls.Add(textBoxNumero);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Cursor = Cursors.PanNW;
            panelPrincipal.Location = new Point(12, 12);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(776, 426);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxTabla
            // 
            richTextBoxTabla.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxTabla.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxTabla.Location = new Point(400, 118);
            richTextBoxTabla.Name = "richTextBoxTabla";
            richTextBoxTabla.Size = new Size(338, 257);
            richTextBoxTabla.TabIndex = 4;
            richTextBoxTabla.Text = "";
            // 
            // buttonShowTab
            // 
            buttonShowTab.BackColor = Color.FromArgb(128, 128, 255);
            buttonShowTab.Font = new Font("DejaVu Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonShowTab.Location = new Point(54, 170);
            buttonShowTab.Name = "buttonShowTab";
            buttonShowTab.Size = new Size(100, 30);
            buttonShowTab.TabIndex = 3;
            buttonShowTab.Text = "Show table";
            buttonShowTab.UseVisualStyleBackColor = false;
            buttonShowTab.Click += buttonShowTab_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.BorderStyle = BorderStyle.FixedSingle;
            textBoxNumero.ForeColor = SystemColors.MenuText;
            textBoxNumero.Location = new Point(54, 129);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.ScrollBars = ScrollBars.Both;
            textBoxNumero.Size = new Size(100, 23);
            textBoxNumero.TabIndex = 2;
            textBoxNumero.UseWaitCursor = true;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("DejaVu Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumero.Location = new Point(54, 96);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(252, 15);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "What multiplication table do you want?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.FromArgb(192, 192, 255);
            labelTitulo.BorderStyle = BorderStyle.Fixed3D;
            labelTitulo.Font = new Font("DejaVu Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(241, 32);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(305, 33);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Multiplication Chart";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            labelTitulo.Click += label1_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(269, 393);
            labelName.Name = "labelName";
            labelName.Size = new Size(244, 19);
            labelName.TabIndex = 5;
            labelName.Text = "Made by Darely Quezada Guerrero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelTitulo;
        private Label labelNumero;
        private TextBox textBoxNumero;
        private Button buttonShowTab;
        private RichTextBox richTextBoxTabla;
        private Label labelName;
    }
}
