namespace SoundMixer
{
    partial class F_SoundMixer
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtB_FirstSound = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_SecondSound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_Result = new System.Windows.Forms.TextBox();
            this.bt_Create = new System.Windows.Forms.Button();
            this.bt_Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtB_FirstSound
            // 
            this.txtB_FirstSound.Location = new System.Drawing.Point(177, 23);
            this.txtB_FirstSound.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtB_FirstSound.Name = "txtB_FirstSound";
            this.txtB_FirstSound.Size = new System.Drawing.Size(132, 30);
            this.txtB_FirstSound.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "First audio location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second audio location:";
            // 
            // txtB_SecondSound
            // 
            this.txtB_SecondSound.Location = new System.Drawing.Point(177, 98);
            this.txtB_SecondSound.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtB_SecondSound.Name = "txtB_SecondSound";
            this.txtB_SecondSound.Size = new System.Drawing.Size(132, 30);
            this.txtB_SecondSound.TabIndex = 2;
            this.txtB_SecondSound.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mix audio name:";
            // 
            // txtB_Result
            // 
            this.txtB_Result.Location = new System.Drawing.Point(177, 173);
            this.txtB_Result.Name = "txtB_Result";
            this.txtB_Result.Size = new System.Drawing.Size(132, 30);
            this.txtB_Result.TabIndex = 5;
            // 
            // bt_Create
            // 
            this.bt_Create.Location = new System.Drawing.Point(24, 236);
            this.bt_Create.Name = "bt_Create";
            this.bt_Create.Size = new System.Drawing.Size(90, 38);
            this.bt_Create.TabIndex = 6;
            this.bt_Create.Text = "Create";
            this.bt_Create.UseVisualStyleBackColor = true;
            this.bt_Create.Click += new System.EventHandler(this.bt_Create_Click);
            // 
            // bt_Play
            // 
            this.bt_Play.Location = new System.Drawing.Point(219, 236);
            this.bt_Play.Name = "bt_Play";
            this.bt_Play.Size = new System.Drawing.Size(90, 38);
            this.bt_Play.TabIndex = 7;
            this.bt_Play.Text = "Play";
            this.bt_Play.UseVisualStyleBackColor = true;
            this.bt_Play.Click += new System.EventHandler(this.bt_Play_Click);
            // 
            // F_SoundMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 292);
            this.Controls.Add(this.bt_Play);
            this.Controls.Add(this.bt_Create);
            this.Controls.Add(this.txtB_Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB_SecondSound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_FirstSound);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "F_SoundMixer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sound Mixer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_FirstSound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_SecondSound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB_Result;
        private System.Windows.Forms.Button bt_Create;
        private System.Windows.Forms.Button bt_Play;
    }
}

