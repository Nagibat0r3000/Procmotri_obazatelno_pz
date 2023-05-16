namespace _1131221313123212131
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checksomethin = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pos = new System.Windows.Forms.Label();
            this.doorlock = new System.Windows.Forms.Timer(this.components);
            this.dvizenie = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.revolver = new System.Windows.Forms.PictureBox();
            this.lestnicavverh = new System.Windows.Forms.PictureBox();
            this.doorright = new System.Windows.Forms.PictureBox();
            this.doorleft = new System.Windows.Forms.PictureBox();
            this.doordown = new System.Windows.Forms.PictureBox();
            this.doorup = new System.Windows.Forms.PictureBox();
            this.you = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lestnicavverh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doordown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.you)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(830, -52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 772);
            this.label4.TabIndex = 1;
            this.label4.Tag = "CM";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // checksomethin
            // 
            this.checksomethin.Interval = 1000;
            this.checksomethin.Tick += new System.EventHandler(this.checksomethin_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(834, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Твои координаты:";
            // 
            // pos
            // 
            this.pos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.pos.Location = new System.Drawing.Point(834, 44);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(90, 23);
            this.pos.TabIndex = 3;
            this.pos.Text = "Найди карту";
            this.pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doorlock
            // 
            this.doorlock.Interval = 2000;
            this.doorlock.Tick += new System.EventHandler(this.doorlock_Tick);
            // 
            // dvizenie
            // 
            this.dvizenie.Enabled = true;
            this.dvizenie.Interval = 12;
            this.dvizenie.Tick += new System.EventHandler(this.dvizenie_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(834, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 11;
            this.label1.Tag = "ddd";
            this.label1.Text = "Предмет в руках";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(873, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 23);
            this.label3.TabIndex = 12;
            this.label3.Tag = "ddd";
            this.label3.Text = "1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.pictureBox1.Image = global::_1131221313123212131.Properties.Resources.white_30x30;
            this.pictureBox1.Location = new System.Drawing.Point(868, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "ddd";
            // 
            // revolver
            // 
            this.revolver.BackColor = System.Drawing.Color.Black;
            this.revolver.Image = global::_1131221313123212131.Properties.Resources.revolver;
            this.revolver.Location = new System.Drawing.Point(1493, 142);
            this.revolver.Name = "revolver";
            this.revolver.Size = new System.Drawing.Size(30, 30);
            this.revolver.TabIndex = 9;
            this.revolver.TabStop = false;
            // 
            // lestnicavverh
            // 
            this.lestnicavverh.BackgroundImage = global::_1131221313123212131.Properties.Resources.podyem;
            this.lestnicavverh.Location = new System.Drawing.Point(1630, 0);
            this.lestnicavverh.Name = "lestnicavverh";
            this.lestnicavverh.Size = new System.Drawing.Size(200, 200);
            this.lestnicavverh.TabIndex = 8;
            this.lestnicavverh.TabStop = false;
            this.lestnicavverh.Tag = "startroom";
            this.lestnicavverh.Visible = false;
            // 
            // doorright
            // 
            this.doorright.BackColor = System.Drawing.Color.Brown;
            this.doorright.Location = new System.Drawing.Point(805, 303);
            this.doorright.Name = "doorright";
            this.doorright.Size = new System.Drawing.Size(25, 77);
            this.doorright.TabIndex = 7;
            this.doorright.TabStop = false;
            // 
            // doorleft
            // 
            this.doorleft.BackColor = System.Drawing.Color.Brown;
            this.doorleft.Location = new System.Drawing.Point(-4, 303);
            this.doorleft.Name = "doorleft";
            this.doorleft.Size = new System.Drawing.Size(29, 77);
            this.doorleft.TabIndex = 6;
            this.doorleft.TabStop = false;
            // 
            // doordown
            // 
            this.doordown.BackColor = System.Drawing.Color.Brown;
            this.doordown.Location = new System.Drawing.Point(361, 622);
            this.doordown.Name = "doordown";
            this.doordown.Size = new System.Drawing.Size(77, 29);
            this.doordown.TabIndex = 5;
            this.doordown.TabStop = false;
            // 
            // doorup
            // 
            this.doorup.BackColor = System.Drawing.Color.Brown;
            this.doorup.Location = new System.Drawing.Point(361, -6);
            this.doorup.Name = "doorup";
            this.doorup.Size = new System.Drawing.Size(77, 29);
            this.doorup.TabIndex = 4;
            this.doorup.TabStop = false;
            // 
            // you
            // 
            this.you.BackColor = System.Drawing.Color.Lime;
            this.you.Location = new System.Drawing.Point(300, 300);
            this.you.Name = "you";
            this.you.Size = new System.Drawing.Size(35, 35);
            this.you.TabIndex = 0;
            this.you.TabStop = false;
            this.you.Tag = "ddd";
            this.you.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label5.Location = new System.Drawing.Point(853, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 13;
            this.label5.Tag = "ddd";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label6.Location = new System.Drawing.Point(855, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 14;
            this.label6.Tag = "ddd";
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reload
            // 
            this.reload.Tick += new System.EventHandler(this.reload_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 650);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.revolver);
            this.Controls.Add(this.lestnicavverh);
            this.Controls.Add(this.doorright);
            this.Controls.Add(this.doorleft);
            this.Controls.Add(this.doordown);
            this.Controls.Add(this.doorup);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.you);
            this.Location = new System.Drawing.Point(350, 350);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Что смотрим?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lestnicavverh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doordown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.you)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox you;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer checksomethin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pos;
        private System.Windows.Forms.PictureBox doorup;
        private System.Windows.Forms.PictureBox doordown;
        private System.Windows.Forms.PictureBox doorleft;
        private System.Windows.Forms.PictureBox doorright;
        private System.Windows.Forms.Timer doorlock;
        private System.Windows.Forms.PictureBox lestnicavverh;
        private System.Windows.Forms.Timer dvizenie;
        private System.Windows.Forms.PictureBox revolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer reload;
    }
}

