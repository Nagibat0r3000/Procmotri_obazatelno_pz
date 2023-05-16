using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _1131221313123212131
{
    public partial class Form1 : Form
    {
        //Если ты это читаешь, то имей в иду следующее:
        //Это просто моя дичь, которую я написал по фану за 5 дней
        //Некоторые механики не доделаны, потому что работы еще много и я не закончил
        //Когда плагины вернут?
        int gu=0, gl=0, gd=0, gr=0,playerx,playery,menal=0,op=0,s=0,etaz=-1;
        int playerxstart, playerystart;
        int[] inventory = new int[10]; int inventorychoised=0; int[] inventorydop = new int[10];
        int peredava_v_reload = 0;
        int[,] map = new int[10,10];
        Random rnd = new Random();
        PictureBox pb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                gu = 0;
            }
            if (e.KeyCode == Keys.A)
            {
                gl = 0;
            }
            if (e.KeyCode == Keys.S)
            {
                gd = 0;
            }
            if (e.KeyCode == Keys.D)
            {
                gr = 0;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                gu = 1;
            }
            if (e.KeyCode == Keys.A)
            {
                gl = 1;
            }
            if (e.KeyCode == Keys.S)
            {
                gd = 1;
            }
            if (e.KeyCode == Keys.D)
            {
                gr = 1;
            }
            if(e.KeyCode==Keys.Left)
            {
                item_switch(-1);
            }
            if (e.KeyCode == Keys.Right)
            {
                item_switch(1);
            }
            if(e.KeyCode==Keys.L)
            {
                use(inventorychoised,e);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(you.Location.X!=0)
            you.Left -= 5;
            door();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (you.Location.Y != 0)
                you.Location = new Point(you.Location.X, you.Location.Y - 5);
            door();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.Size != new Size(651, 549))
            {
                this.Size = new Size(651, 549);
                switch (menal)
                {
                    case 0:
                        MessageBox.Show("А вот нельзя менять размеры >:(");
                        break;
                    case 1:
                        MessageBox.Show("НЕЛЬЗЯ");
                        break;
                    case 2:
                        MessageBox.Show("Я СКАЗАЛ НЕЛЬЗЯ");
                        break;
                    case 3:
                        MessageBox.Show("Ты пожалеешь об этом");
                        break;
                    case 4:
                        MessageBox.Show("Это последнее предупреждение");
                        break;
                    case 5:
                        MessageBox.Show("Пшёл вон из моей игры!");
                        Close();
                        break;
                }
                menal++;
            }
        }

        private void checksomethin_Tick(object sender, EventArgs e)
        {
            if (this.Size != new Size(651, 549))
            {
                this.Size = new Size(651, 549);
                switch(menal)
                {
                    case 0:
                        MessageBox.Show("А вот нельзя менять размеры >:(");
                        break;
                    case 1:
                        MessageBox.Show("НЕЛЬЗЯ");
                        break;
                    case 2:
                        MessageBox.Show("Я СКАЗАЛ НЕЛЬЗЯ");
                        break;
                    case 3:
                        MessageBox.Show("Ты пожалеешь об этом");
                        break;
                    case 4:
                        MessageBox.Show("Это последнее предупреждение");
                        break;
                    case 5:
                        MessageBox.Show("Пшёл вон из моей игры!");
                        Close();
                        break;
                }
                menal++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dvizenie_Tick(object sender, EventArgs e)
        {

            if (gl == 1)
            {
                if(you.Location.X!=0)
                you.Left -= 5;
            }
            if(gu == 1)
            {
                if (you.Location.Y != 0)
                    you.Location = new Point(you.Location.X, you.Location.Y - 5);
            }
            if(gr == 1)
            {
                if (you.Location.X != 795)
                    you.Left += 5;
            }
            if (gd == 1)
            {
                if (you.Location.Y != 620)
                    you.Location = new Point(you.Location.X, you.Location.Y + 5);
            }
            if (you.Bounds.IntersectsWith(pb.Bounds))
            {
                goup();
            }
            if(you.Bounds.IntersectsWith(revolver.Bounds) && revolver.Visible)
            {
                item_pickup(101,1);
            }
            door();
        }
        private void goup()
        {
            etaz++;
            switch (etaz)
            {
                case 0:

                    break;
                case -1:

                    break;
            }
        }

        private void reload_Tick(object sender, EventArgs e)
        {
            int f=0;
            float time=0;
            switch(peredava_v_reload)
            {
                case 101:
                    if(f!=1)
                        time = 6;
                    f = 1;
                    break;
            }
            if(f==1)
            {
                time -= (float) 0.1;
                label5.Text = time.ToString();
            }
        }

        private void doorlock_Tick(object sender, EventArgs e)
        {
            s += 1;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<9;i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (map[i, j] == 101)
                    {
                        //MessageBox.Show(i.ToString()+j.ToString()+"\n" + revolver.Visible.ToString() + "\n" + revolver.Location.ToString());
                        if(playerxstart - i ==-1)
                        {
                            MessageBox.Show("Вправо");
                        }
                        if (playerystart - j == -1)
                        {
                            MessageBox.Show("Вниз");
                        }
                        if (playerxstart - i == 1)
                        {
                            MessageBox.Show("Влево");
                        }
                        if (playerystart - j == 1)
                        {
                            MessageBox.Show("Вверх");
                        }
                    }
                }
            }
            // MessageBox.Show(you.Location.ToString());
           // MessageBox.Show(revolver.Visible.ToString()+"\n"+revolver.Location.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb = lestnicavverh;
            MaximizeBox = false;
            for (int i = 0; i < 10; i++)
            {
                inventory[i] = 0;
                for (int j = 0; j < 10; j++)
                {
                    map[i, j] = 0;
                }
            }
            playerx = rnd.Next(0,9);
            playery = rnd.Next(0,9);
            playerxstart = playerx;
            playerystart = playery;
            pos.Text = playerx.ToString() + " " + playery.ToString();
            map[playerx, playery] = 1;
            item_spawn_loc(101, 1, 100);
            RoomChange(1); RoomChange(2); RoomChange(3); RoomChange(4);
        }
        private void RoomChange(int napravlenie)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "dd")
                {
                    x.Tag = null;
                }
                if (x is PictureBox && x.Tag != "dd" && x.Tag != "ddd")
                {
                    x.Hide();
                }
            }
            switch (map[playerx,playery])
            {
                case 1:
                    this.BackColor = Color.FromArgb(192, 255, 192);
                    lestnicavverh.Visible = true;
                    lestnicavverh.Location = new Point(630, 0);
                    lestnicavverh.Tag = "dd";
                    this.Controls.Add(pb);
                    foreach (Control x in this.Controls)
                    {
                        if (x is PictureBox && x.Tag != "dd" && x.Tag != "ddd")
                        {
                            x.Hide();
                        }
                    }
                    break;
                case 101:
                    revolver.Show();
                    revolver.Location = new Point(300,300);
                    revolver.Tag = "dd";
                    this.BackColor = Color.FromArgb(67,63,63);
                    foreach (Control x in this.Controls)
                    {
                        if (x is PictureBox && x.Tag != "dd" && x.Tag!="ddd")
                        {
                            x.Hide();
                        }
                    }
                    break;
                default:
                    foreach (Control x in this.Controls)
                    {
                        if(x is PictureBox && x.Tag == "dd")
                        {
                            x.Tag = null;
                        }
                        if (x is PictureBox && x.Tag != "dd" && x.Tag != "ddd")
                        {
                            x.Hide();
                        }
                    }
                    this.BackColor = Color.White;
                    break;
            }
            switch(op)
            {
                case 1:
                    you.Location = new Point(770, you.Location.Y);
                    break;
                case 2:
                    you.Location = new Point(you.Location.X, 585); 
                    break;
                case 3:
                    you.Location = new Point(25,you.Location.Y);
                    break;
                case 4:
                    you.Location = new Point(you.Location.X, 25);
                    break;
            }
            if(playerx-1==-1 || map[playerx-1,playery]==-1)
            {
                doorleft.Hide();
            }
            else
            {
                doorleft.Show();
            }
            if (playery + 1 == 10 || map[playerx, playery+1] == -1)
            {
                doordown.Hide();
            }
            else
            {
                doordown.Show();
            }
            if (playerx + 1 == 10 || map[playerx + 1, playery] == -1)
            {
                doorright.Hide();
            }
            else
            {
                doorright.Show();
            }
            if (playery - 1 == -1 || map[playerx, playery-1] == -1)
            {
                doorup.Hide();
            }
            else
            {
                doorup.Show();
            }
            pos.Text = playerx.ToString() + " " + playery.ToString();
        }
        private void door()
        {
            if(you.Bounds.IntersectsWith(doorup.Bounds) && doorup.Visible)
            {
                playery--;
                op = 2;
                RoomChange(2);
            }
            if (you.Bounds.IntersectsWith(doordown.Bounds) && doordown.Visible)
            {
                playery++;
                op = 4;
                RoomChange(4);
            }
            if (you.Bounds.IntersectsWith(doorleft.Bounds) && doorleft.Visible)
            {
                playerx--;
                op = 1;
                RoomChange(1);
            }
            if (you.Bounds.IntersectsWith(doorright.Bounds) && doorright.Visible)
            {
                playerx++;
                op = 3;
                RoomChange(3);
            }
        }
        private void item_spawn_loc(int id,int dalnost, int chance)
        {
            int x = rnd.Next(0, 9);
            int y = rnd.Next(0, 9);
            int aboba;
            bool che = true;
            while(che)
            {
                x = rnd.Next(0, 9);
                y = rnd.Next(0, 9);
                aboba = Math.Abs(playerxstart - x) + Math.Abs(playerystart - y);
                if (map[x, y] == 0)
                {
                    if (aboba == dalnost)
                    {
                        break;
                    }
                }
            }
            item_spawn(id, x, y);
        }
        private void item_spawn(int id,int x,int y)
        {
            int chzx = y;
            switch (id)
            {
                case 101:
                    map[x, y] = 101;
                    revolver.Location = new Point(300, 300);
                    revolver.Hide();
                    break;
            }
        }
        private void item_pickup(int id, int type)
        {
            int f = 0,n=0;
            for (int i = 0; i < 10; i++)
            {
                if (inventory[i]==0)
                {
                    f = 1;
                    n = i;
                    inventory[i] = id;
                    break;
                }    
            }
            if(f==0)
            {
                MessageBox.Show("В инвентаре нет места");
                return;
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (map[i, j] == id)
                    {
                        map[i, j] = 0;
                        this.BackColor = Color.White;
                    }
                }
            }
            switch (id)
            {
                case 101:
                    revolver.Hide();
                    inventorydop[n] = 6;
                    break;
            }
            item_switch(0);
        }
        private void item_switch(int n)
        {
            inventorychoised += n;
            if (inventorychoised == -1)
            {
                inventorychoised = 9;
            }
            else
            {
                if (inventorychoised == 10)
                {
                    inventorychoised = 0;
                }
            }
            switch (inventory[inventorychoised])
            {
                case 101:
                    pictureBox1.Image = Properties.Resources.revolver;
                    label6.Text = inventorydop[inventorychoised].ToString();
                    break;
                case 0:
                    pictureBox1.Image = Properties.Resources.white_30x30;
                    break;
            }
            label3.Text = (inventorychoised + 1).ToString();

        }
        private void use(int item, EventArgs e)
        {
            switch(inventory[item])
            {
                case 101:
                    if (inventorydop[inventorychoised] > 0)
                    {
                        inventorydop[inventorychoised] -= 1;
                        label5.Text = inventorydop[inventorychoised].ToString();
                        peredava_v_reload = 101;
                        reload_Tick(this, e);
                    }
                    break;
            }
        }
    }
}