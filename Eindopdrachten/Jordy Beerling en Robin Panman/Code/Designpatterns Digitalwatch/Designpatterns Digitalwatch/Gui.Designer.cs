namespace Designpatterns_Digitalwatch
{
    partial class Gui
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TzLabel = new System.Windows.Forms.Label();
            this.Button_right = new System.Windows.Forms.PictureBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.Button_left = new System.Windows.Forms.PictureBox();
            this.Button_center = new System.Windows.Forms.PictureBox();
            this.sevenSegment6 = new digitalWatch.SevenSegment();
            this.sevenSegment5 = new digitalWatch.SevenSegment();
            this.sevenSegment4 = new digitalWatch.SevenSegment();
            this.sevenSegment3 = new digitalWatch.SevenSegment();
            this.sevenSegment2 = new digitalWatch.SevenSegment();
            this.sevenSegment1 = new digitalWatch.SevenSegment();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_center)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(131, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 315);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 76);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // TzLabel
            // 
            this.TzLabel.AutoSize = true;
            this.TzLabel.BackColor = System.Drawing.Color.Transparent;
            this.TzLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TzLabel.ForeColor = System.Drawing.Color.White;
            this.TzLabel.Location = new System.Drawing.Point(413, 223);
            this.TzLabel.Name = "TzLabel";
            this.TzLabel.Size = new System.Drawing.Size(80, 46);
            this.TzLabel.TabIndex = 8;
            this.TzLabel.Text = "AM";
            // 
            // Button_right
            // 
            this.Button_right.Image = global::Designpatterns_Digitalwatch.Properties.Resources.dg_btn_right;
            this.Button_right.Location = new System.Drawing.Point(575, 285);
            this.Button_right.Name = "Button_right";
            this.Button_right.Size = new System.Drawing.Size(21, 84);
            this.Button_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Button_right.TabIndex = 9;
            this.Button_right.TabStop = false;
            this.Button_right.Click += new System.EventHandler(this.Button_right_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.BackColor = System.Drawing.Color.Transparent;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.ForeColor = System.Drawing.Color.White;
            this.TextLabel.Location = new System.Drawing.Point(146, 296);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(103, 31);
            this.TextLabel.TabIndex = 10;
            this.TextLabel.Text = "testtext";
            // 
            // Button_left
            // 
            this.Button_left.Image = global::Designpatterns_Digitalwatch.Properties.Resources.dg_btn_left;
            this.Button_left.Location = new System.Drawing.Point(61, 278);
            this.Button_left.Name = "Button_left";
            this.Button_left.Size = new System.Drawing.Size(20, 80);
            this.Button_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Button_left.TabIndex = 11;
            this.Button_left.TabStop = false;
            this.Button_left.Click += new System.EventHandler(this.Button_left_Click);
            // 
            // Button_center
            // 
            this.Button_center.Image = global::Designpatterns_Digitalwatch.Properties.Resources.dg_btn_center;
            this.Button_center.Location = new System.Drawing.Point(304, 503);
            this.Button_center.Name = "Button_center";
            this.Button_center.Size = new System.Drawing.Size(36, 38);
            this.Button_center.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Button_center.TabIndex = 12;
            this.Button_center.TabStop = false;
            this.Button_center.Click += new System.EventHandler(this.Button_center_Click);
            // 
            // sevenSegment6
            // 
            this.sevenSegment6.BackColor = System.Drawing.Color.Transparent;
            this.sevenSegment6.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenSegment6.ColorDark = System.Drawing.Color.Transparent;
            this.sevenSegment6.ColorLight = System.Drawing.Color.White;
            this.sevenSegment6.CustomPattern = 0;
            this.sevenSegment6.DecimalOn = false;
            this.sevenSegment6.DecimalShow = true;
            this.sevenSegment6.ElementWidth = 10;
            this.sevenSegment6.ItalicFactor = 0F;
            this.sevenSegment6.Location = new System.Drawing.Point(461, 278);
            this.sevenSegment6.Name = "sevenSegment6";
            this.sevenSegment6.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment6.Size = new System.Drawing.Size(32, 64);
            this.sevenSegment6.TabIndex = 6;
            this.sevenSegment6.TabStop = false;
            this.sevenSegment6.Value = null;
            // 
            // sevenSegment5
            // 
            this.sevenSegment5.BackColor = System.Drawing.Color.Transparent;
            this.sevenSegment5.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenSegment5.ColorDark = System.Drawing.Color.Transparent;
            this.sevenSegment5.ColorLight = System.Drawing.Color.White;
            this.sevenSegment5.CustomPattern = 0;
            this.sevenSegment5.DecimalOn = false;
            this.sevenSegment5.DecimalShow = true;
            this.sevenSegment5.ElementWidth = 10;
            this.sevenSegment5.ItalicFactor = 0F;
            this.sevenSegment5.Location = new System.Drawing.Point(421, 278);
            this.sevenSegment5.Name = "sevenSegment5";
            this.sevenSegment5.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment5.Size = new System.Drawing.Size(32, 64);
            this.sevenSegment5.TabIndex = 5;
            this.sevenSegment5.TabStop = false;
            this.sevenSegment5.Value = null;
            // 
            // sevenSegment4
            // 
            this.sevenSegment4.BackColor = System.Drawing.Color.Transparent;
            this.sevenSegment4.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenSegment4.ColorDark = System.Drawing.Color.Transparent;
            this.sevenSegment4.ColorLight = System.Drawing.Color.White;
            this.sevenSegment4.CustomPattern = 0;
            this.sevenSegment4.DecimalOn = false;
            this.sevenSegment4.DecimalShow = true;
            this.sevenSegment4.ElementWidth = 10;
            this.sevenSegment4.ItalicFactor = 0F;
            this.sevenSegment4.Location = new System.Drawing.Point(375, 210);
            this.sevenSegment4.Name = "sevenSegment4";
            this.sevenSegment4.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment4.Size = new System.Drawing.Size(32, 64);
            this.sevenSegment4.TabIndex = 4;
            this.sevenSegment4.TabStop = false;
            this.sevenSegment4.Value = null;
            // 
            // sevenSegment3
            // 
            this.sevenSegment3.BackColor = System.Drawing.Color.Transparent;
            this.sevenSegment3.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenSegment3.ColorDark = System.Drawing.Color.Transparent;
            this.sevenSegment3.ColorLight = System.Drawing.Color.White;
            this.sevenSegment3.CustomPattern = 0;
            this.sevenSegment3.DecimalOn = false;
            this.sevenSegment3.DecimalShow = true;
            this.sevenSegment3.ElementWidth = 10;
            this.sevenSegment3.ItalicFactor = 0F;
            this.sevenSegment3.Location = new System.Drawing.Point(337, 210);
            this.sevenSegment3.Name = "sevenSegment3";
            this.sevenSegment3.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment3.Size = new System.Drawing.Size(32, 64);
            this.sevenSegment3.TabIndex = 3;
            this.sevenSegment3.TabStop = false;
            this.sevenSegment3.Value = null;
            // 
            // sevenSegment2
            // 
            this.sevenSegment2.BackColor = System.Drawing.Color.Transparent;
            this.sevenSegment2.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenSegment2.ColorDark = System.Drawing.Color.Transparent;
            this.sevenSegment2.ColorLight = System.Drawing.Color.White;
            this.sevenSegment2.CustomPattern = 0;
            this.sevenSegment2.DecimalOn = false;
            this.sevenSegment2.DecimalShow = true;
            this.sevenSegment2.ElementWidth = 10;
            this.sevenSegment2.ItalicFactor = 0F;
            this.sevenSegment2.Location = new System.Drawing.Point(250, 210);
            this.sevenSegment2.Name = "sevenSegment2";
            this.sevenSegment2.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment2.Size = new System.Drawing.Size(32, 64);
            this.sevenSegment2.TabIndex = 2;
            this.sevenSegment2.TabStop = false;
            this.sevenSegment2.Value = null;
            // 
            // sevenSegment1
            // 
            this.sevenSegment1.BackColor = System.Drawing.Color.Transparent;
            this.sevenSegment1.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenSegment1.ColorDark = System.Drawing.Color.Transparent;
            this.sevenSegment1.ColorLight = System.Drawing.Color.White;
            this.sevenSegment1.CustomPattern = 0;
            this.sevenSegment1.DecimalOn = false;
            this.sevenSegment1.DecimalShow = true;
            this.sevenSegment1.ElementWidth = 10;
            this.sevenSegment1.ItalicFactor = 0F;
            this.sevenSegment1.Location = new System.Drawing.Point(212, 210);
            this.sevenSegment1.Name = "sevenSegment1";
            this.sevenSegment1.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment1.Size = new System.Drawing.Size(32, 64);
            this.sevenSegment1.TabIndex = 1;
            this.sevenSegment1.TabStop = false;
            this.sevenSegment1.Value = null;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Designpatterns_Digitalwatch.Properties.Resources.dgWatchSmall;
            this.ClientSize = new System.Drawing.Size(634, 612);
            this.Controls.Add(this.Button_center);
            this.Controls.Add(this.Button_left);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.Button_right);
            this.Controls.Add(this.TzLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sevenSegment6);
            this.Controls.Add(this.sevenSegment5);
            this.Controls.Add(this.sevenSegment4);
            this.Controls.Add(this.sevenSegment3);
            this.Controls.Add(this.sevenSegment2);
            this.Controls.Add(this.sevenSegment1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Gui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_center)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private digitalWatch.SevenSegment sevenSegment1;
        private digitalWatch.SevenSegment sevenSegment2;
        private digitalWatch.SevenSegment sevenSegment3;
        private digitalWatch.SevenSegment sevenSegment4;
        private digitalWatch.SevenSegment sevenSegment5;
        private digitalWatch.SevenSegment sevenSegment6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TzLabel;
        private System.Windows.Forms.PictureBox Button_right;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.PictureBox Button_left;
        private System.Windows.Forms.PictureBox Button_center;
    }
}

