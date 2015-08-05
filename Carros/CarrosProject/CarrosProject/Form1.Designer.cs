namespace CarrosProject
{
    partial class JanelaBuscaCarro
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
            this.BtnBuscarPlaca = new System.Windows.Forms.Button();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelKm = new System.Windows.Forms.Label();
            this.labelCapacidadeTanque = new System.Windows.Forms.Label();
            this.labelPotencia = new System.Windows.Forms.Label();
            this.TbModelo = new System.Windows.Forms.TextBox();
            this.TbPlaca = new System.Windows.Forms.TextBox();
            this.TbMarca = new System.Windows.Forms.TextBox();
            this.TbAno = new System.Windows.Forms.TextBox();
            this.TbQuilometragem = new System.Windows.Forms.TextBox();
            this.TbCapacidadeTanque = new System.Windows.Forms.TextBox();
            this.TbPotencia = new System.Windows.Forms.TextBox();
            this.TbBuscarPlaca = new System.Windows.Forms.TextBox();
            this.BtnSalvarCarro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBuscarPlaca
            // 
            this.BtnBuscarPlaca.Location = new System.Drawing.Point(35, 455);
            this.BtnBuscarPlaca.Name = "BtnBuscarPlaca";
            this.BtnBuscarPlaca.Size = new System.Drawing.Size(102, 23);
            this.BtnBuscarPlaca.TabIndex = 0;
            this.BtnBuscarPlaca.Text = "Buscar placa";
            this.BtnBuscarPlaca.UseVisualStyleBackColor = true;
            this.BtnBuscarPlaca.Click += new System.EventHandler(this.BtnBuscarPlaca_Click);
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(32, 58);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 1;
            this.labelModelo.Text = "Modelo";
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(32, 91);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(34, 13);
            this.labelPlaca.TabIndex = 2;
            this.labelPlaca.Text = "Placa";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(32, 132);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(32, 174);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(26, 13);
            this.labelAno.TabIndex = 4;
            this.labelAno.Text = "Ano";
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Location = new System.Drawing.Point(32, 215);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(77, 13);
            this.labelKm.TabIndex = 5;
            this.labelKm.Text = "Quilometragem";
            // 
            // labelCapacidadeTanque
            // 
            this.labelCapacidadeTanque.AutoSize = true;
            this.labelCapacidadeTanque.Location = new System.Drawing.Point(32, 267);
            this.labelCapacidadeTanque.Name = "labelCapacidadeTanque";
            this.labelCapacidadeTanque.Size = new System.Drawing.Size(115, 13);
            this.labelCapacidadeTanque.TabIndex = 6;
            this.labelCapacidadeTanque.Text = "Capacidade do tanque";
            // 
            // labelPotencia
            // 
            this.labelPotencia.AutoSize = true;
            this.labelPotencia.Location = new System.Drawing.Point(32, 314);
            this.labelPotencia.Name = "labelPotencia";
            this.labelPotencia.Size = new System.Drawing.Size(49, 13);
            this.labelPotencia.TabIndex = 7;
            this.labelPotencia.Text = "Potencia";
            // 
            // TbModelo
            // 
            this.TbModelo.Location = new System.Drawing.Point(185, 51);
            this.TbModelo.Name = "TbModelo";
            this.TbModelo.Size = new System.Drawing.Size(100, 20);
            this.TbModelo.TabIndex = 8;
            // 
            // TbPlaca
            // 
            this.TbPlaca.Location = new System.Drawing.Point(185, 84);
            this.TbPlaca.Name = "TbPlaca";
            this.TbPlaca.Size = new System.Drawing.Size(100, 20);
            this.TbPlaca.TabIndex = 9;
            // 
            // TbMarca
            // 
            this.TbMarca.Location = new System.Drawing.Point(185, 125);
            this.TbMarca.Name = "TbMarca";
            this.TbMarca.Size = new System.Drawing.Size(100, 20);
            this.TbMarca.TabIndex = 10;
            // 
            // TbAno
            // 
            this.TbAno.Location = new System.Drawing.Point(185, 167);
            this.TbAno.Name = "TbAno";
            this.TbAno.Size = new System.Drawing.Size(100, 20);
            this.TbAno.TabIndex = 11;
            // 
            // TbKm
            // 
            this.TbQuilometragem.Location = new System.Drawing.Point(185, 208);
            this.TbQuilometragem.Name = "TbKm";
            this.TbQuilometragem.Size = new System.Drawing.Size(100, 20);
            this.TbQuilometragem.TabIndex = 12;
            // 
            // TbCapacidadeTanque
            // 
            this.TbCapacidadeTanque.Location = new System.Drawing.Point(185, 260);
            this.TbCapacidadeTanque.Name = "TbCapacidadeTanque";
            this.TbCapacidadeTanque.Size = new System.Drawing.Size(100, 20);
            this.TbCapacidadeTanque.TabIndex = 13;
            // 
            // TbPotencia
            // 
            this.TbPotencia.Location = new System.Drawing.Point(185, 307);
            this.TbPotencia.Name = "TbPotencia";
            this.TbPotencia.Size = new System.Drawing.Size(100, 20);
            this.TbPotencia.TabIndex = 14;
            // 
            // TbBuscarPlaca
            // 
            this.TbBuscarPlaca.Location = new System.Drawing.Point(185, 458);
            this.TbBuscarPlaca.Name = "TbBuscarPlaca";
            this.TbBuscarPlaca.Size = new System.Drawing.Size(100, 20);
            this.TbBuscarPlaca.TabIndex = 15;
            // 
            // BtnSalvarCarro
            // 
            this.BtnSalvarCarro.Location = new System.Drawing.Point(35, 401);
            this.BtnSalvarCarro.Name = "BtnSalvarCarro";
            this.BtnSalvarCarro.Size = new System.Drawing.Size(102, 23);
            this.BtnSalvarCarro.TabIndex = 16;
            this.BtnSalvarCarro.Text = "Salvar carro";
            this.BtnSalvarCarro.UseVisualStyleBackColor = true;
            this.BtnSalvarCarro.Click += new System.EventHandler(this.BtnSalvarCarro_Click);
            // 
            // JanelaBuscaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 534);
            this.Controls.Add(this.BtnSalvarCarro);
            this.Controls.Add(this.TbBuscarPlaca);
            this.Controls.Add(this.TbPotencia);
            this.Controls.Add(this.TbCapacidadeTanque);
            this.Controls.Add(this.TbQuilometragem);
            this.Controls.Add(this.TbAno);
            this.Controls.Add(this.TbMarca);
            this.Controls.Add(this.TbPlaca);
            this.Controls.Add(this.TbModelo);
            this.Controls.Add(this.labelPotencia);
            this.Controls.Add(this.labelCapacidadeTanque);
            this.Controls.Add(this.labelKm);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.BtnBuscarPlaca);
            this.Name = "JanelaBuscaCarro";
            this.Text = "Janela busca carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarPlaca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.Label labelCapacidadeTanque;
        private System.Windows.Forms.Label labelPotencia;
        private System.Windows.Forms.TextBox TbModelo;
        private System.Windows.Forms.TextBox TbPlaca;
        private System.Windows.Forms.TextBox TbMarca;
        private System.Windows.Forms.TextBox TbAno;
        private System.Windows.Forms.TextBox TbQuilometragem;
        private System.Windows.Forms.TextBox TbCapacidadeTanque;
        private System.Windows.Forms.TextBox TbPotencia;
        private System.Windows.Forms.TextBox TbBuscarPlaca;
        private System.Windows.Forms.Button BtnSalvarCarro;
    }
}

