namespace WinFormTabla
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
            labelNombre = new Label();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(128, 128, 255);
            panelPrincipal.Controls.Add(labelNombre);
            panelPrincipal.Controls.Add(richTextBoxResultados);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(textBoxNum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(12, 12);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(303, 331);
            panelPrincipal.TabIndex = 0;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(65, 307);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(176, 15);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Carlos Antonio Villaseñor Garcia";
            labelNombre.Click += labelNombre_Click;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.BackColor = Color.FromArgb(192, 192, 255);
            richTextBoxResultados.Location = new Point(142, 49);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(117, 212);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackColor = Color.FromArgb(192, 192, 255);
            buttonVer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVer.ForeColor = Color.Black;
            buttonVer.Location = new Point(36, 124);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(75, 23);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver Tabla";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.BackColor = Color.FromArgb(192, 192, 255);
            textBoxNum.Location = new Point(23, 80);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(100, 23);
            textBoxNum.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(14, 49);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(109, 15);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Que tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.FromArgb(192, 192, 255);
            labelTitulo.ForeColor = Color.Black;
            labelTitulo.Location = new Point(14, 19);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(115, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tablas de Multiplicar";
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
        private TextBox textBoxNum;
        private Label labelNumero;
        private Label labelTitulo;
        private RichTextBox richTextBoxResultados;
        private Button buttonVer;
        private Label labelNombre;
    }
}
