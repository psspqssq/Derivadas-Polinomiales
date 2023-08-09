namespace Derivadas_Polinomiales
{
    partial class frmMain
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
            txtFuncion = new TextBox();
            label1 = new Label();
            btnDerivar = new Button();
            label2 = new Label();
            picResult = new PictureBox();
            txtResult = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picResult).BeginInit();
            SuspendLayout();
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(77, 15);
            txtFuncion.Margin = new Padding(4, 3, 4, 3);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(200, 23);
            txtFuncion.TabIndex = 0;
            txtFuncion.TextChanged += txtFuncion_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "f(x)";
            // 
            // btnDerivar
            // 
            btnDerivar.Location = new Point(285, 14);
            btnDerivar.Margin = new Padding(4, 3, 4, 3);
            btnDerivar.Name = "btnDerivar";
            btnDerivar.Size = new Size(82, 24);
            btnDerivar.TabIndex = 2;
            btnDerivar.Text = "Derivar";
            btnDerivar.UseVisualStyleBackColor = true;
            btnDerivar.Click += btnDerivar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Derivada:";
            // 
            // picResult
            // 
            picResult.Location = new Point(77, 73);
            picResult.Name = "picResult";
            picResult.Size = new Size(200, 57);
            picResult.TabIndex = 4;
            picResult.TabStop = false;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(76, 44);
            txtResult.Margin = new Padding(4, 3, 4, 3);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(200, 23);
            txtResult.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 6;
            label3.Text = "Por: Pablo Silva";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 143);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 7;
            label4.Text = "Grupo: 3AV";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 167);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtResult);
            Controls.Add(picResult);
            Controls.Add(label2);
            Controls.Add(btnDerivar);
            Controls.Add(label1);
            Controls.Add(txtFuncion);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            Text = "Derivadas Polinomiales";
            ((System.ComponentModel.ISupportInitialize)picResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFuncion;
        private Label label1;
        private Button btnDerivar;
        private Label label2;
        private PictureBox picResult;
        private TextBox txtResult;
        private Label label3;
        private Label label4;
    }
}