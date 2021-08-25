
namespace ProjetoIA
{
    partial class GrupoRiscoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrupoRiscoForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNaoGrupoRisco = new System.Windows.Forms.Button();
            this.btnSimGrupoRisco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Grupo de risco";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "DIABETES",
            "HIPERTENSÃO",
            "DOENÇAS CARDIO RESPIRATÓRIAS",
            "OBESIDADE",
            "FUMANTE"});
            this.listBox1.Location = new System.Drawing.Point(12, 329);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 99);
            this.listBox1.TabIndex = 29;
            // 
            // btnNaoGrupoRisco
            // 
            this.btnNaoGrupoRisco.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNaoGrupoRisco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNaoGrupoRisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaoGrupoRisco.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNaoGrupoRisco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNaoGrupoRisco.Location = new System.Drawing.Point(150, 243);
            this.btnNaoGrupoRisco.Name = "btnNaoGrupoRisco";
            this.btnNaoGrupoRisco.Padding = new System.Windows.Forms.Padding(5);
            this.btnNaoGrupoRisco.Size = new System.Drawing.Size(250, 46);
            this.btnNaoGrupoRisco.TabIndex = 28;
            this.btnNaoGrupoRisco.Text = "NÃO";
            this.btnNaoGrupoRisco.UseVisualStyleBackColor = false;
            this.btnNaoGrupoRisco.Click += new System.EventHandler(this.btnNaoGrupoRisco_Click);
            // 
            // btnSimGrupoRisco
            // 
            this.btnSimGrupoRisco.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimGrupoRisco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimGrupoRisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimGrupoRisco.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSimGrupoRisco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSimGrupoRisco.Location = new System.Drawing.Point(150, 182);
            this.btnSimGrupoRisco.Name = "btnSimGrupoRisco";
            this.btnSimGrupoRisco.Padding = new System.Windows.Forms.Padding(5);
            this.btnSimGrupoRisco.Size = new System.Drawing.Size(250, 46);
            this.btnSimGrupoRisco.TabIndex = 27;
            this.btnSimGrupoRisco.Text = "SIM";
            this.btnSimGrupoRisco.UseVisualStyleBackColor = false;
            this.btnSimGrupoRisco.Click += new System.EventHandler(this.btnSimGrupoRisco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(129, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Você faz parte do grupo de risco?";
            // 
            // GrupoRiscoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNaoGrupoRisco);
            this.Controls.Add(this.btnSimGrupoRisco);
            this.Controls.Add(this.label1);
            this.Name = "GrupoRiscoForm";
            this.Text = "GrupoRiscoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNaoGrupoRisco;
        private System.Windows.Forms.Button btnSimGrupoRisco;
        private System.Windows.Forms.Label label1;
    }
}