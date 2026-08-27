namespace JogoCorridaWinFormsApp
{
    partial class FormInicio
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
            btnFacil_click = new Button();
            btnMedio_click = new Button();
            btnDificil_click = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // btnFacil_click
            // 
            btnFacil_click.BackColor = Color.FromArgb(192, 255, 192);
            btnFacil_click.Location = new Point(106, 189);
            btnFacil_click.Name = "btnFacil_click";
            btnFacil_click.Size = new Size(138, 49);
            btnFacil_click.TabIndex = 0;
            btnFacil_click.Text = "FÁCIL";
            btnFacil_click.UseVisualStyleBackColor = false;
            btnFacil_click.Click += btnFacil_click_Click;
            // 
            // btnMedio_click
            // 
            btnMedio_click.BackColor = Color.FromArgb(255, 255, 192);
            btnMedio_click.Location = new Point(271, 189);
            btnMedio_click.Name = "btnMedio_click";
            btnMedio_click.Size = new Size(158, 49);
            btnMedio_click.TabIndex = 1;
            btnMedio_click.Text = "MÉDIO";
            btnMedio_click.UseVisualStyleBackColor = false;
            btnMedio_click.Click += button2_Click;
            // 
            // btnDificil_click
            // 
            btnDificil_click.BackColor = Color.FromArgb(255, 192, 192);
            btnDificil_click.Location = new Point(458, 189);
            btnDificil_click.Name = "btnDificil_click";
            btnDificil_click.RightToLeft = RightToLeft.No;
            btnDificil_click.Size = new Size(124, 49);
            btnDificil_click.TabIndex = 2;
            btnDificil_click.Text = "DIFÍCIL";
            btnDificil_click.UseVisualStyleBackColor = false;
            btnDificil_click.Click += btnDificil_click_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(106, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(476, 28);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione o Nível";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(317, 331);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "SAIR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(btnDificil_click);
            Controls.Add(btnMedio_click);
            Controls.Add(btnFacil_click);
            Name = "FormInicio";
            Text = "FormInicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFacil_click;
        private Button btnMedio_click;
        private Button btnDificil_click;
        private GroupBox groupBox1;
        private Button button4;
    }
}