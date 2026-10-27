namespace pryRepasoPerez
{
    partial class cargaDatos
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
            txtCajaCodigo = new TextBox();
            lblCodigo = new Label();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // txtCajaCodigo
            // 
            txtCajaCodigo.Location = new Point(64, 52);
            txtCajaCodigo.Name = "txtCajaCodigo";
            txtCajaCodigo.Size = new Size(100, 23);
            txtCajaCodigo.TabIndex = 0;
            txtCajaCodigo.KeyPress += txtCajaCodigo_KeyPress;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 55);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(173, 198);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cargaDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 245);
            Controls.Add(btnRegistrar);
            Controls.Add(lblCodigo);
            Controls.Add(txtCajaCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "cargaDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCajaCodigo;
        private Label lblCodigo;
        private Button btnRegistrar;
    }
}