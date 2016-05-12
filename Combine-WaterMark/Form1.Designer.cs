namespace Combine_WaterMark
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Do = new System.Windows.Forms.Button();
            this.NeedWater = new System.Windows.Forms.Button();
            this.WaterLabel = new System.Windows.Forms.Label();
            this.SelectWater = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.yulan = new System.Windows.Forms.PictureBox();
            this.show = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.selectWaterDialog = new System.Windows.Forms.OpenFileDialog();
            this.NeedWaterDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yulan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.Do);
            this.tabPage1.Controls.Add(this.NeedWater);
            this.tabPage1.Controls.Add(this.WaterLabel);
            this.tabPage1.Controls.Add(this.SelectWater);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "添加水印";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(232, 64);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(75, 23);
            this.Do.TabIndex = 3;
            this.Do.Text = "添加水印";
            this.Do.UseVisualStyleBackColor = true;
            this.Do.Click += new System.EventHandler(this.Do_Click);
            // 
            // NeedWater
            // 
            this.NeedWater.Location = new System.Drawing.Point(18, 64);
            this.NeedWater.Name = "NeedWater";
            this.NeedWater.Size = new System.Drawing.Size(152, 23);
            this.NeedWater.TabIndex = 2;
            this.NeedWater.Text = "选择需要添加水印文件";
            this.NeedWater.UseVisualStyleBackColor = true;
            this.NeedWater.Click += new System.EventHandler(this.NeedWater_Click);
            // 
            // WaterLabel
            // 
            this.WaterLabel.AutoSize = true;
            this.WaterLabel.Location = new System.Drawing.Point(136, 27);
            this.WaterLabel.Name = "WaterLabel";
            this.WaterLabel.Size = new System.Drawing.Size(0, 12);
            this.WaterLabel.TabIndex = 1;
            // 
            // SelectWater
            // 
            this.SelectWater.Location = new System.Drawing.Point(18, 17);
            this.SelectWater.Name = "SelectWater";
            this.SelectWater.Size = new System.Drawing.Size(87, 23);
            this.SelectWater.TabIndex = 0;
            this.SelectWater.Text = "选择水印文件";
            this.SelectWater.UseVisualStyleBackColor = true;
            this.SelectWater.Click += new System.EventHandler(this.SelectWater_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.yulan);
            this.tabPage2.Controls.Add(this.show);
            this.tabPage2.Controls.Add(this.up);
            this.tabPage2.Controls.Add(this.down);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "合并图片";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // yulan
            // 
            this.yulan.Location = new System.Drawing.Point(484, 61);
            this.yulan.Name = "yulan";
            this.yulan.Size = new System.Drawing.Size(430, 508);
            this.yulan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yulan.TabIndex = 6;
            this.yulan.TabStop = false;
            this.yulan.Visible = false;
            this.yulan.DoubleClick += new System.EventHandler(this.yulan_DoubleClick);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(484, 19);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 5;
            this.show.Tag = ".BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;";
            this.show.Text = "预览";
            this.show.UseVisualStyleBackColor = true;
            this.show.Visible = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(350, 19);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 23);
            this.up.TabIndex = 4;
            this.up.Tag = ".BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;";
            this.up.Text = "上移";
            this.up.UseVisualStyleBackColor = true;
            this.up.Visible = false;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(269, 19);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(75, 23);
            this.down.TabIndex = 3;
            this.down.Tag = ".BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;";
            this.down.Text = "下移";
            this.down.UseVisualStyleBackColor = true;
            this.down.Visible = false;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "共选择 0 个图片";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "查看";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "图片文件|*.jpg;*.png;*.bmp";
            this.openFileDialog1.Multiselect = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "图片文件|*.jpg";
            // 
            // selectWaterDialog
            // 
            this.selectWaterDialog.Filter = "图片文件|*.jpg;*.png;*.bmp";
            // 
            // NeedWaterDialog
            // 
            this.NeedWaterDialog.Filter = "图片文件|*.jpg;*.png;*.bmp";
            this.NeedWaterDialog.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 579);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ImageCombine-WaterMark";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yulan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.PictureBox yulan;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button NeedWater;
        private System.Windows.Forms.Label WaterLabel;
        private System.Windows.Forms.Button SelectWater;
        private System.Windows.Forms.Button Do;
        private System.Windows.Forms.OpenFileDialog selectWaterDialog;
        private System.Windows.Forms.OpenFileDialog NeedWaterDialog;
    }
}

