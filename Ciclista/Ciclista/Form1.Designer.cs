namespace Ciclista
{
    partial class frm_RegistroCiclistas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_equi = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.dataCiclista = new System.Windows.Forms.DataGridView();
            this.cmb_dorsal = new System.Windows.Forms.ComboBox();
            this.cmb_pais = new System.Windows.Forms.ComboBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCiclista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE CICLISTAS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dorsal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Equipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Apellido";
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(304, 71);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 23);
            this.txt_nom.TabIndex = 0;
            this.txt_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nom_KeyPress_1);
            // 
            // txt_equi
            // 
            this.txt_equi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_equi.Location = new System.Drawing.Point(304, 155);
            this.txt_equi.Name = "txt_equi";
            this.txt_equi.Size = new System.Drawing.Size(100, 23);
            this.txt_equi.TabIndex = 11;
            this.txt_equi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_equi_KeyPress);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(304, 129);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 23);
            this.txt_id.TabIndex = 12;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress_1);
            // 
            // txt_ape
            // 
            this.txt_ape.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ape.Location = new System.Drawing.Point(304, 103);
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(100, 23);
            this.txt_ape.TabIndex = 13;
            this.txt_ape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ape_KeyPress_1);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(87, 404);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(154, 34);
            this.btn_ingresar.TabIndex = 14;
            this.btn_ingresar.Text = "AGREGAR";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // dataCiclista
            // 
            this.dataCiclista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataCiclista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataCiclista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCiclista.Location = new System.Drawing.Point(62, 248);
            this.dataCiclista.Name = "dataCiclista";
            this.dataCiclista.Size = new System.Drawing.Size(407, 150);
            this.dataCiclista.TabIndex = 15;
            this.dataCiclista.Visible = false;
            this.dataCiclista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCiclista_CellClick);
            // 
            // cmb_dorsal
            // 
            this.cmb_dorsal.FormattingEnabled = true;
            this.cmb_dorsal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmb_dorsal.Location = new System.Drawing.Point(304, 184);
            this.cmb_dorsal.Name = "cmb_dorsal";
            this.cmb_dorsal.Size = new System.Drawing.Size(100, 21);
            this.cmb_dorsal.TabIndex = 16;
            this.cmb_dorsal.SelectedIndexChanged += new System.EventHandler(this.cmb_dorsal_SelectedIndexChanged);
            // 
            // cmb_pais
            // 
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Items.AddRange(new object[] {
            "Ecuador",
            "Peru",
            "Colombia",
            "Argentina",
            "Boliva",
            "Chile",
            "Mexico",
            "EEUU",
            "Brasil"});
            this.cmb_pais.Location = new System.Drawing.Point(304, 214);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(100, 21);
            this.cmb_pais.TabIndex = 17;
            this.cmb_pais.SelectedIndexChanged += new System.EventHandler(this.cmb_pais_SelectedIndexChanged);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(283, 404);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(154, 34);
            this.btn_modificar.TabIndex = 26;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // frm_RegistroCiclistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 480);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.cmb_pais);
            this.Controls.Add(this.cmb_dorsal);
            this.Controls.Add(this.dataCiclista);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_ape);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_equi);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_RegistroCiclistas";
            this.Text = "Registro Ciclistas";
            this.Load += new System.EventHandler(this.frm_RegistroCiclistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCiclista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_equi;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.DataGridView dataCiclista;
        private System.Windows.Forms.ComboBox cmb_dorsal;
        private System.Windows.Forms.ComboBox cmb_pais;
        private System.Windows.Forms.Button btn_modificar;
    }
}

