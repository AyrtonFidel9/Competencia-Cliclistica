namespace WinAppLogin
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkcontra = new System.Windows.Forms.CheckBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.pxb_visible = new System.Windows.Forms.PictureBox();
            this.pxb_Salir = new System.Windows.Forms.PictureBox();
            this.pxb_novisible = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_visible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_novisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkcontra
            // 
            this.checkcontra.AutoSize = true;
            this.checkcontra.Location = new System.Drawing.Point(298, 224);
            this.checkcontra.Margin = new System.Windows.Forms.Padding(2);
            this.checkcontra.Name = "checkcontra";
            this.checkcontra.Size = new System.Drawing.Size(15, 14);
            this.checkcontra.TabIndex = 24;
            this.checkcontra.UseVisualStyleBackColor = true;
            this.checkcontra.CheckedChanged += new System.EventHandler(this.checkcontra_CheckedChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Location = new System.Drawing.Point(129, 221);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(165, 20);
            this.txt_Password.TabIndex = 23;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // txt_User
            // 
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_User.Location = new System.Drawing.Point(129, 172);
            this.txt_User.Margin = new System.Windows.Forms.Padding(2);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(165, 20);
            this.txt_User.TabIndex = 22;
            this.txt_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_User_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "PASSWORD: \r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "USER: ";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(35)))));
            this.btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Location = new System.Drawing.Point(66, 257);
            this.btn_Ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(260, 29);
            this.btn_Ingresar.TabIndex = 26;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // pxb_visible
            // 
            this.pxb_visible.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pxb_visible.Image = global::WinAppLogin.Properties.Resources.ojo_ojo;
            this.pxb_visible.Location = new System.Drawing.Point(317, 216);
            this.pxb_visible.Margin = new System.Windows.Forms.Padding(2);
            this.pxb_visible.Name = "pxb_visible";
            this.pxb_visible.Size = new System.Drawing.Size(23, 25);
            this.pxb_visible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxb_visible.TabIndex = 28;
            this.pxb_visible.TabStop = false;
            this.pxb_visible.Visible = false;
            // 
            // pxb_Salir
            // 
            this.pxb_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxb_Salir.Image = ((System.Drawing.Image)(resources.GetObject("pxb_Salir.Image")));
            this.pxb_Salir.Location = new System.Drawing.Point(330, 1);
            this.pxb_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.pxb_Salir.Name = "pxb_Salir";
            this.pxb_Salir.Size = new System.Drawing.Size(34, 32);
            this.pxb_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxb_Salir.TabIndex = 27;
            this.pxb_Salir.TabStop = false;
            this.pxb_Salir.Click += new System.EventHandler(this.pxb_Salir_Click);
            // 
            // pxb_novisible
            // 
            this.pxb_novisible.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pxb_novisible.Image = global::WinAppLogin.Properties.Resources.no_visible;
            this.pxb_novisible.Location = new System.Drawing.Point(317, 216);
            this.pxb_novisible.Margin = new System.Windows.Forms.Padding(2);
            this.pxb_novisible.Name = "pxb_novisible";
            this.pxb_novisible.Size = new System.Drawing.Size(23, 25);
            this.pxb_novisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxb_novisible.TabIndex = 25;
            this.pxb_novisible.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(375, 333);
            this.Controls.Add(this.pxb_visible);
            this.Controls.Add(this.pxb_Salir);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.checkcontra);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pxb_novisible);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pxb_visible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_novisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkcontra;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pxb_novisible;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.PictureBox pxb_Salir;
        private System.Windows.Forms.PictureBox pxb_visible;
    }
}

