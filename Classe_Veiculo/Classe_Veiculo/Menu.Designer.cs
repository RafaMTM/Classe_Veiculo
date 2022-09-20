namespace Classe_Veiculo
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.btn_Sair = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_Caminhao = new System.Windows.Forms.PictureBox();
            this.btn_Caminhao = new System.Windows.Forms.Button();
            this.btn_Carro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Caminhao)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Sair.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(391, 278);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(86, 41);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(295, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pb_Caminhao
            // 
            this.pb_Caminhao.BackColor = System.Drawing.Color.DarkOrange;
            this.pb_Caminhao.Image = ((System.Drawing.Image)(resources.GetObject("pb_Caminhao.Image")));
            this.pb_Caminhao.Location = new System.Drawing.Point(295, 58);
            this.pb_Caminhao.Name = "pb_Caminhao";
            this.pb_Caminhao.Size = new System.Drawing.Size(67, 50);
            this.pb_Caminhao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Caminhao.TabIndex = 8;
            this.pb_Caminhao.TabStop = false;
            // 
            // btn_Caminhao
            // 
            this.btn_Caminhao.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Caminhao.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.btn_Caminhao.ForeColor = System.Drawing.Color.White;
            this.btn_Caminhao.Location = new System.Drawing.Point(120, 48);
            this.btn_Caminhao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Caminhao.Name = "btn_Caminhao";
            this.btn_Caminhao.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Caminhao.Size = new System.Drawing.Size(262, 69);
            this.btn_Caminhao.TabIndex = 7;
            this.btn_Caminhao.Text = "Caminhão";
            this.btn_Caminhao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Caminhao.UseVisualStyleBackColor = false;
            this.btn_Caminhao.Click += new System.EventHandler(this.btn_Caminhao_Click);
            // 
            // btn_Carro
            // 
            this.btn_Carro.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Carro.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.btn_Carro.ForeColor = System.Drawing.Color.White;
            this.btn_Carro.Location = new System.Drawing.Point(120, 159);
            this.btn_Carro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Carro.Name = "btn_Carro";
            this.btn_Carro.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Carro.Size = new System.Drawing.Size(262, 69);
            this.btn_Carro.TabIndex = 6;
            this.btn_Carro.Text = "Carro";
            this.btn_Carro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Carro.UseVisualStyleBackColor = false;
            this.btn_Carro.Click += new System.EventHandler(this.btn_Carro_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(502, 335);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_Caminhao);
            this.Controls.Add(this.btn_Caminhao);
            this.Controls.Add(this.btn_Carro);
            this.Controls.Add(this.btn_Sair);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Caminhao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb_Caminhao;
        private System.Windows.Forms.Button btn_Caminhao;
        private System.Windows.Forms.Button btn_Carro;
    }
}