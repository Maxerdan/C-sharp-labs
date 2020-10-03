namespace Lab4
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
            if (DroidThrd != null) DroidThrd.Abort();
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_soldier_pl = new System.Windows.Forms.Button();
            this.b_soldier_mi = new System.Windows.Forms.Button();
            this.b_tank_pl = new System.Windows.Forms.Button();
            this.b_tank_mi = new System.Windows.Forms.Button();
            this.b_plane_pl = new System.Windows.Forms.Button();
            this.b_plane_mi = new System.Windows.Forms.Button();
            this.b_officer_pl = new System.Windows.Forms.Button();
            this.b_officer_mi = new System.Windows.Forms.Button();
            this.b_activate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.field_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поле";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Статус";
            // 
            // status_box
            // 
            this.status_box.Location = new System.Drawing.Point(271, 25);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(224, 20);
            this.status_box.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вражеский солдат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Вражеский танк";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Вражеский самолет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Наш офицер";
            // 
            // b_soldier_pl
            // 
            this.b_soldier_pl.Location = new System.Drawing.Point(382, 137);
            this.b_soldier_pl.Name = "b_soldier_pl";
            this.b_soldier_pl.Size = new System.Drawing.Size(52, 20);
            this.b_soldier_pl.TabIndex = 8;
            this.b_soldier_pl.Text = "+";
            this.b_soldier_pl.UseVisualStyleBackColor = true;
            this.b_soldier_pl.Click += new System.EventHandler(this.b_soldier_pl_Click);
            // 
            // b_soldier_mi
            // 
            this.b_soldier_mi.Location = new System.Drawing.Point(440, 137);
            this.b_soldier_mi.Name = "b_soldier_mi";
            this.b_soldier_mi.Size = new System.Drawing.Size(52, 20);
            this.b_soldier_mi.TabIndex = 9;
            this.b_soldier_mi.Text = "-";
            this.b_soldier_mi.UseVisualStyleBackColor = true;
            this.b_soldier_mi.Click += new System.EventHandler(this.b_soldier_mi_Click);
            // 
            // b_tank_pl
            // 
            this.b_tank_pl.Location = new System.Drawing.Point(382, 163);
            this.b_tank_pl.Name = "b_tank_pl";
            this.b_tank_pl.Size = new System.Drawing.Size(52, 20);
            this.b_tank_pl.TabIndex = 10;
            this.b_tank_pl.Text = "+";
            this.b_tank_pl.UseVisualStyleBackColor = true;
            this.b_tank_pl.Click += new System.EventHandler(this.b_tank_pl_Click);
            // 
            // b_tank_mi
            // 
            this.b_tank_mi.Location = new System.Drawing.Point(440, 163);
            this.b_tank_mi.Name = "b_tank_mi";
            this.b_tank_mi.Size = new System.Drawing.Size(52, 20);
            this.b_tank_mi.TabIndex = 11;
            this.b_tank_mi.Text = "-";
            this.b_tank_mi.UseVisualStyleBackColor = true;
            this.b_tank_mi.Click += new System.EventHandler(this.b_tank_mi_Click);
            // 
            // b_plane_pl
            // 
            this.b_plane_pl.Location = new System.Drawing.Point(382, 189);
            this.b_plane_pl.Name = "b_plane_pl";
            this.b_plane_pl.Size = new System.Drawing.Size(52, 20);
            this.b_plane_pl.TabIndex = 12;
            this.b_plane_pl.Text = "+";
            this.b_plane_pl.UseVisualStyleBackColor = true;
            this.b_plane_pl.Click += new System.EventHandler(this.b_plane_pl_Click);
            // 
            // b_plane_mi
            // 
            this.b_plane_mi.Location = new System.Drawing.Point(440, 189);
            this.b_plane_mi.Name = "b_plane_mi";
            this.b_plane_mi.Size = new System.Drawing.Size(52, 20);
            this.b_plane_mi.TabIndex = 13;
            this.b_plane_mi.Text = "-";
            this.b_plane_mi.UseVisualStyleBackColor = true;
            this.b_plane_mi.Click += new System.EventHandler(this.b_plane_mi_Click);
            // 
            // b_officer_pl
            // 
            this.b_officer_pl.Location = new System.Drawing.Point(382, 215);
            this.b_officer_pl.Name = "b_officer_pl";
            this.b_officer_pl.Size = new System.Drawing.Size(52, 20);
            this.b_officer_pl.TabIndex = 14;
            this.b_officer_pl.Text = "+";
            this.b_officer_pl.UseVisualStyleBackColor = true;
            this.b_officer_pl.Click += new System.EventHandler(this.b_officer_pl_Click);
            // 
            // b_officer_mi
            // 
            this.b_officer_mi.Location = new System.Drawing.Point(440, 215);
            this.b_officer_mi.Name = "b_officer_mi";
            this.b_officer_mi.Size = new System.Drawing.Size(52, 20);
            this.b_officer_mi.TabIndex = 15;
            this.b_officer_mi.Text = "-";
            this.b_officer_mi.UseVisualStyleBackColor = true;
            this.b_officer_mi.Click += new System.EventHandler(this.b_officer_mi_Click);
            // 
            // b_activate
            // 
            this.b_activate.Location = new System.Drawing.Point(271, 51);
            this.b_activate.Name = "b_activate";
            this.b_activate.Size = new System.Drawing.Size(221, 80);
            this.b_activate.TabIndex = 16;
            this.b_activate.Text = "Активировать";
            this.b_activate.UseVisualStyleBackColor = true;
            this.b_activate.Click += new System.EventHandler(this.b_activate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // field_listbox
            // 
            this.field_listbox.FormattingEnabled = true;
            this.field_listbox.Location = new System.Drawing.Point(12, 25);
            this.field_listbox.Name = "field_listbox";
            this.field_listbox.Size = new System.Drawing.Size(253, 212);
            this.field_listbox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 253);
            this.Controls.Add(this.field_listbox);
            this.Controls.Add(this.b_activate);
            this.Controls.Add(this.b_officer_mi);
            this.Controls.Add(this.b_officer_pl);
            this.Controls.Add(this.b_plane_mi);
            this.Controls.Add(this.b_plane_pl);
            this.Controls.Add(this.b_tank_mi);
            this.Controls.Add(this.b_tank_pl);
            this.Controls.Add(this.b_soldier_mi);
            this.Controls.Add(this.b_soldier_pl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Тактическое поле ведения боевых действий";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox status_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_soldier_pl;
        private System.Windows.Forms.Button b_soldier_mi;
        private System.Windows.Forms.Button b_tank_pl;
        private System.Windows.Forms.Button b_tank_mi;
        private System.Windows.Forms.Button b_plane_pl;
        private System.Windows.Forms.Button b_plane_mi;
        private System.Windows.Forms.Button b_officer_pl;
        private System.Windows.Forms.Button b_officer_mi;
        private System.Windows.Forms.Button b_activate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox field_listbox;
    }
}

