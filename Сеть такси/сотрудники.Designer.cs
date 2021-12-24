namespace Сеть_такси
{
    partial class сотрудники
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Обновление = new System.Windows.Forms.Button();
            this.Удаление = new System.Windows.Forms.Button();
            this.Добавление = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(170)))), ((int)(((byte)(214)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(773, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сотрудники";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(170)))), ((int)(((byte)(214)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Обновление
            // 
            this.Обновление.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Обновление.Location = new System.Drawing.Point(321, 300);
            this.Обновление.Name = "Обновление";
            this.Обновление.Size = new System.Drawing.Size(141, 39);
            this.Обновление.TabIndex = 9;
            this.Обновление.Text = "Обновить";
            this.Обновление.UseVisualStyleBackColor = true;
            this.Обновление.Click += new System.EventHandler(this.Обновление_Click);
            // 
            // Удаление
            // 
            this.Удаление.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Удаление.Location = new System.Drawing.Point(500, 300);
            this.Удаление.Name = "Удаление";
            this.Удаление.Size = new System.Drawing.Size(141, 39);
            this.Удаление.TabIndex = 10;
            this.Удаление.Text = "Удалить";
            this.Удаление.UseVisualStyleBackColor = true;
            this.Удаление.Click += new System.EventHandler(this.Удаление_Click);
            // 
            // Добавление
            // 
            this.Добавление.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Добавление.Location = new System.Drawing.Point(137, 300);
            this.Добавление.Name = "Добавление";
            this.Добавление.Size = new System.Drawing.Size(141, 39);
            this.Добавление.TabIndex = 11;
            this.Добавление.Text = "Добавить";
            this.Добавление.UseVisualStyleBackColor = true;
            this.Добавление.Click += new System.EventHandler(this.Добавление_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(250, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(292, 44);
            this.button4.TabIndex = 12;
            this.button4.Text = "Вернуться назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // сотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(170)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(792, 463);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Добавление);
            this.Controls.Add(this.Удаление);
            this.Controls.Add(this.Обновление);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "сотрудники";
            this.Text = "сотрудники";
            this.Load += new System.EventHandler(this.сотрудники_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Обновление;
        private System.Windows.Forms.Button Удаление;
        private System.Windows.Forms.Button Добавление;
        private System.Windows.Forms.Button button4;
    }
}