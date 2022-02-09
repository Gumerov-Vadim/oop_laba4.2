namespace gui_cs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Condition = new System.Windows.Forms.Label();
            this.nud_c = new System.Windows.Forms.NumericUpDown();
            this.nud_a = new System.Windows.Forms.NumericUpDown();
            this.nud_b = new System.Windows.Forms.NumericUpDown();
            this.track_c = new System.Windows.Forms.TrackBar();
            this.track_b = new System.Windows.Forms.TrackBar();
            this.track_a = new System.Windows.Forms.TrackBar();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_a = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_a)).BeginInit();
            this.SuspendLayout();
            // 
            // Condition
            // 
            this.Condition.AutoSize = true;
            this.Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Condition.Location = new System.Drawing.Point(119, 9);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(581, 108);
            this.Condition.TabIndex = 0;
            this.Condition.Text = "A <= B <= C";
            // 
            // nud_c
            // 
            this.nud_c.Location = new System.Drawing.Point(550, 221);
            this.nud_c.Name = "nud_c";
            this.nud_c.Size = new System.Drawing.Size(150, 20);
            this.nud_c.TabIndex = 1;
            this.nud_c.ValueChanged += new System.EventHandler(this.nud_c_ValueChanged);
            // 
            // nud_a
            // 
            this.nud_a.Location = new System.Drawing.Point(137, 221);
            this.nud_a.Name = "nud_a";
            this.nud_a.Size = new System.Drawing.Size(136, 20);
            this.nud_a.TabIndex = 2;
            this.nud_a.ValueChanged += new System.EventHandler(this.nud_a_ValueChanged);
            // 
            // nud_b
            // 
            this.nud_b.Location = new System.Drawing.Point(342, 221);
            this.nud_b.Name = "nud_b";
            this.nud_b.Size = new System.Drawing.Size(150, 20);
            this.nud_b.TabIndex = 3;
            this.nud_b.ValueChanged += new System.EventHandler(this.nud_b_ValueChanged);
            // 
            // track_c
            // 
            this.track_c.Location = new System.Drawing.Point(550, 328);
            this.track_c.Maximum = 100;
            this.track_c.Name = "track_c";
            this.track_c.Size = new System.Drawing.Size(150, 45);
            this.track_c.TabIndex = 4;
            this.track_c.Scroll += new System.EventHandler(this.track_c_Scroll);
            // 
            // track_b
            // 
            this.track_b.Location = new System.Drawing.Point(342, 328);
            this.track_b.Maximum = 100;
            this.track_b.Name = "track_b";
            this.track_b.Size = new System.Drawing.Size(150, 45);
            this.track_b.TabIndex = 5;
            this.track_b.Scroll += new System.EventHandler(this.track_b_Scroll);
            // 
            // track_a
            // 
            this.track_a.Location = new System.Drawing.Point(137, 328);
            this.track_a.Maximum = 100;
            this.track_a.Name = "track_a";
            this.track_a.Size = new System.Drawing.Size(150, 45);
            this.track_a.TabIndex = 6;
            this.track_a.Scroll += new System.EventHandler(this.track_a_Scroll);
            // 
            // tb_c
            // 
            this.tb_c.Location = new System.Drawing.Point(550, 264);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(150, 20);
            this.tb_c.TabIndex = 7;
            this.tb_c.TextChanged += new System.EventHandler(this.tb_c_TextChanged);
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(342, 264);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(150, 20);
            this.tb_b.TabIndex = 8;
            this.tb_b.TextChanged += new System.EventHandler(this.tb_b_TextChanged);
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(137, 264);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(136, 20);
            this.tb_a.TabIndex = 9;
            this.tb_a.TextChanged += new System.EventHandler(this.tb_a_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_c);
            this.Controls.Add(this.track_a);
            this.Controls.Add(this.track_b);
            this.Controls.Add(this.track_c);
            this.Controls.Add(this.nud_b);
            this.Controls.Add(this.nud_a);
            this.Controls.Add(this.nud_c);
            this.Controls.Add(this.Condition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Condition;
        private System.Windows.Forms.NumericUpDown nud_c;
        private System.Windows.Forms.NumericUpDown nud_a;
        private System.Windows.Forms.NumericUpDown nud_b;
        private System.Windows.Forms.TrackBar track_c;
        private System.Windows.Forms.TrackBar track_b;
        private System.Windows.Forms.TrackBar track_a;
        private System.Windows.Forms.TextBox tb_c;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_a;
    }
}

