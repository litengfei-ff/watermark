using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Combine_WaterMark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //定义存放文件名和路径的泛型SoredList
        SortedList<int,string> list=new SortedList<int,string>();

        //选择文件
        private void button1_Click(object sender, EventArgs e)
        {
            //点击打开按钮而且选择文件不为空时执行
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileNames.Length != 0)
            {
                Console.WriteLine("选择文件完毕");
                label1.Text = "共选择 "+openFileDialog1.FileNames.Length+" 个图片";

            }
        }
        //查看文件
        private void button2_Click(object sender, EventArgs e)
        {
            //隐藏预览
            yulan.Visible = false;
            //清空list
            list.Clear();
            //清空预览图片
            yulan.Image = null;
            //显示移动、预览按钮
            down.Visible = up.Visible = show.Visible = false;
            if (openFileDialog1.FileNames.Length>1)
            {
                  down.Visible = up.Visible = show.Visible = true;
            }

            //循环添加list
            for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
            {
                list.Add(i, openFileDialog1.FileNames[i]);
                
            }

            MBind();
          
        }
        //绑定方法
        private void MBind()
        {
            //清除Panel
            for (int i = 0; i < tabPage2.Controls.Count; i++)
            {
                if (tabPage2.Controls["sp" + i] != null)
                {
                    tabPage2.Controls["sp" + i].Dispose();
                }
            }

           
            //定义初始位置
            Point position = new Point(20, 90);

            for (int i = 0; i < list.Count; i++)
            {

            //动态生产 panel,label picbox
            string FullName = list[i];
            string Name = list[i].Substring(list[i].LastIndexOf("\\")+1);

            //Label
            Label slabel = new Label();
            slabel.AutoSize = true;
            slabel.Location = new System.Drawing.Point(13, 13);
            slabel.Name = "slabel1";
            slabel.Size = new System.Drawing.Size(40, 12);
            slabel.TabIndex = 0;
            slabel.Text = "文件名：" + Name;


            //pic
            //获取选择图片对象
            Image SrcImg = Image.FromFile(FullName);
            //新建指定高宽的图片
            Bitmap newImg = new System.Drawing.Bitmap(234, 113);
            Graphics g = Graphics.FromImage(newImg);
            g.DrawImage(SrcImg, 0, 0, 234, 113);

            PictureBox spic = new PictureBox();
            spic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            spic.Location = new System.Drawing.Point(15, 37);
            spic.Name = "spic1";
            spic.Size = new System.Drawing.Size(234, 113);
            spic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            spic.TabIndex = 1;
            spic.TabStop = false;
            spic.Image = newImg;

            //panel
            Panel sp = new Panel();
            sp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            sp.Controls.Add(spic);
            sp.Controls.Add(slabel);
            sp.Location = position;
            sp.Name = "sp" + i;
            sp.Size = new System.Drawing.Size(266, 160);
            sp.TabIndex = 3;
            sp.Click += new EventHandler(sp_Click);


            //position改变
            position = new Point(position.X, position.Y + 170);
            //添加到list
            tabPage2.Controls.Add(sp);
         
            }
        }
        //鼠标点击显示选中
        void sp_Click(object sender, EventArgs e)
        {
            for (int i=7; i < tabPage2.Controls.Count; i++)
            {
          
                    (tabPage2.Controls[i] as Panel).BorderStyle = System.Windows.Forms.BorderStyle.None;
             
            }
            (sender as Panel).BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        //下移
        private void down_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count-1; i++)
            {
                if ((tabPage2.Controls["sp" + i] as Panel).BorderStyle == System.Windows.Forms.BorderStyle.Fixed3D) {

                    string temp;
                    temp = list[i];
                    list[i] = list[i + 1];
                    list[i + 1] = temp;
                    MBind();
                }
            }
        }
        //上移
        private void up_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if ((tabPage2.Controls["sp" + i] as Panel).BorderStyle == System.Windows.Forms.BorderStyle.Fixed3D)
                {

                    string temp;
                    temp = list[i];
                    list[i] = list[i - 1];
                    list[i - 1] = temp;
                    MBind();
                }
            }

        }
        //窗口改变事件
        private void Form1_Resize(object sender, EventArgs e)
        {
            //窗口大小改变
            Size FormSize = this.Size;
            tabControl1.Size = new Size((FormSize.Width - 30), FormSize.Height - 60);
            yulan.Size = new Size((FormSize.Width - 30)/2+100, (FormSize.Height - 60)/2+100);
        }
        //预览
        private void show_Click(object sender, EventArgs e)
        {
            yulan.Image = DrawImg();
            yulan.Visible = true;
          
        }
        //绘图方法
        private Bitmap DrawImg()
        {
            int width = Image.FromFile(list[0]).Width;
            int height = Image.FromFile(list[0]).Height;

            Bitmap newImg = new System.Drawing.Bitmap(width, height * list.Count);
            Graphics g = Graphics.FromImage(newImg);

            for (int i = 0; i < list.Count; i++)
            {
                Image SrcImg = Image.FromFile(list[i]);
                g.DrawImage(SrcImg, 0, i * height, width, height);
            }
            return newImg;
        }
        //保存图片方法
        private void yulan_DoubleClick(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                Bitmap newImg = DrawImg();
                newImg.Save(saveFileDialog1.FileName,System.Drawing.Imaging.ImageFormat.Jpeg);
             
            }
        }
        //选择水印文件
        private void SelectWater_Click(object sender, EventArgs e)
        {
            if (selectWaterDialog.ShowDialog() == DialogResult.OK) {

                WaterLabel.Text = selectWaterDialog.SafeFileName;
            
            }
        }
        //选择需要添加水印文件
        private void NeedWater_Click(object sender, EventArgs e)
        {
            if (NeedWaterDialog.ShowDialog() == DialogResult.OK)
            {
                //清除原label
                int count=tabPage1.Controls.Count;
                for (int i = 0; i <count ; i++)
                {
                    if (tabPage1.Controls["slabel" + i] != null)
                    {
                        (tabPage1.Controls["slabel" + i] as Label).Dispose();
                    }
                }


                //初始化位置
                Point position = new Point(18, 110);    
                //生成label
                for (int i = 0; i < NeedWaterDialog.FileNames.Length; i++)
                {
                        Label slabel = new Label();
                        slabel.AutoSize = true;
                        slabel.Location = position;
                        slabel.Name = "slabel"+i;
                        slabel.Size = new System.Drawing.Size(40, 12);
                        slabel.TabIndex = 0;
                        slabel.Text = NeedWaterDialog.SafeFileNames[i];
                        tabPage1.Controls.Add(slabel);

                        position = new Point(18,position.Y+30);
                }

            }
        }

        //点击添加水印按钮
        private void Do_Click(object sender, EventArgs e)
        {
           
            if (WaterLabel.Text!=""&&tabPage1.Controls["slabel0"]!=null)
            {
                //创建目录
                if (!Directory.Exists("e:\\1\\"))
                {
                    Directory.CreateDirectory("e:\\1\\");
                }

                ThreadPool.QueueUserWorkItem(AddWater);
                (sender as Button).Text = "进行中。。。";
                (sender as Button).Enabled = false;
            }

         
        }

        //添加水印方法
        private  void AddWater(object o)
        {


            for (int i = 0; i < tabPage1.Controls.Count - 4; i++)
            {
                string src=NeedWaterDialog.FileNames[i];
                string water = selectWaterDialog.FileName;
                Image SrcImg = Image.FromFile(src);
                Image Water=Image.FromFile(water);

                Graphics g = Graphics.FromImage(SrcImg);

                g.DrawImage(Water, 0,0,Water.Width,Water.Height );
                SrcImg.Save("E:\\1\\water-"+src.Substring(src.LastIndexOf("\\")+1) ,System.Drawing.Imaging.ImageFormat.Jpeg);

            }

            //button文字返回为原值
            Button btn = tabPage1.Controls["Do"] as Button;
            
            //跨线程操作
            this.Invoke(new Action(() => { 
                btn.Text = "添加水印";
                btn.Enabled = true;
            }));
            MessageBox.Show("ok，文件已保存到E盘下1文件夹中", "提示");
        

        }

       
    }
}
