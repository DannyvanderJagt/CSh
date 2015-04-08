namespace DigitalWatch
{
    partial class Watch
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
            this.components = new System.ComponentModel.Container();
            this.btnModus = new System.Windows.Forms.Button();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.segmentDisplay2 = new WindowsFormsControlLibrary1.SegmentDisplay();
            this.segmentDisplay3 = new WindowsFormsControlLibrary1.SegmentDisplay();
            this.segmentDisplay4 = new WindowsFormsControlLibrary1.SegmentDisplay();
            this.secondtimer = new System.Windows.Forms.Timer(this.components);
            this.lblColon = new System.Windows.Forms.Label();
            this.incrementtimer = new System.Windows.Forms.Timer(this.components);
            this.lblAMPM = new System.Windows.Forms.Label();
            this.segmentDisplay1 = new WindowsFormsControlLibrary1.SegmentDisplay();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModus
            // 
            this.btnModus.BackColor = System.Drawing.Color.Transparent;
            this.btnModus.FlatAppearance.BorderSize = 0;
            this.btnModus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModus.Location = new System.Drawing.Point(217, 99);
            this.btnModus.Name = "btnModus";
            this.btnModus.Size = new System.Drawing.Size(17, 20);
            this.btnModus.TabIndex = 4;
            this.btnModus.UseVisualStyleBackColor = false;
            this.btnModus.Click += new System.EventHandler(this.btnModus_Click);
            // 
            // btnIncrement
            // 
            this.btnIncrement.BackColor = System.Drawing.Color.Transparent;
            this.btnIncrement.FlatAppearance.BorderSize = 0;
            this.btnIncrement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIncrement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrement.Location = new System.Drawing.Point(217, 181);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(16, 23);
            this.btnIncrement.TabIndex = 5;
            this.btnIncrement.UseVisualStyleBackColor = false;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            this.btnIncrement.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIncrement_MouseUp);
            // 
            // segmentDisplay2
            // 
            this.segmentDisplay2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.segmentDisplay2.Location = new System.Drawing.Point(124, 137);
            this.segmentDisplay2.Name = "segmentDisplay2";
            this.segmentDisplay2.Size = new System.Drawing.Size(14, 26);
            this.segmentDisplay2.TabIndex = 8;
            // 
            // segmentDisplay3
            // 
            this.segmentDisplay3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.segmentDisplay3.Location = new System.Drawing.Point(159, 137);
            this.segmentDisplay3.Name = "segmentDisplay3";
            this.segmentDisplay3.Size = new System.Drawing.Size(14, 26);
            this.segmentDisplay3.TabIndex = 9;
            // 
            // segmentDisplay4
            // 
            this.segmentDisplay4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.segmentDisplay4.Location = new System.Drawing.Point(179, 137);
            this.segmentDisplay4.Name = "segmentDisplay4";
            this.segmentDisplay4.Size = new System.Drawing.Size(14, 26);
            this.segmentDisplay4.TabIndex = 10;
            // 
            // secondtimer
            // 
            this.secondtimer.Enabled = true;
            this.secondtimer.Interval = 1000;
            this.secondtimer.Tick += new System.EventHandler(this.secondtimer_Tick);
            // 
            // lblColon
            // 
            this.lblColon.BackColor = System.Drawing.Color.Transparent;
            this.lblColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblColon.ForeColor = System.Drawing.Color.Red;
            this.lblColon.Location = new System.Drawing.Point(139, 132);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(16, 28);
            this.lblColon.TabIndex = 11;
            this.lblColon.Text = ":";
            // 
            // incrementtimer
            // 
            this.incrementtimer.Interval = 500;
            this.incrementtimer.Tick += new System.EventHandler(this.incrementtimer_Tick);
            // 
            // lblAMPM
            // 
            this.lblAMPM.AutoSize = true;
            this.lblAMPM.BackColor = System.Drawing.Color.Transparent;
            this.lblAMPM.Font = new System.Drawing.Font("Digital-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMPM.ForeColor = System.Drawing.Color.Red;
            this.lblAMPM.Location = new System.Drawing.Point(120, 171);
            this.lblAMPM.Name = "lblAMPM";
            this.lblAMPM.Size = new System.Drawing.Size(24, 17);
            this.lblAMPM.TabIndex = 12;
            this.lblAMPM.Text = "AM";
            this.lblAMPM.Visible = false;
            // 
            // segmentDisplay1
            // 
            this.segmentDisplay1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.segmentDisplay1.Location = new System.Drawing.Point(104, 137);
            this.segmentDisplay1.Name = "segmentDisplay1";
            this.segmentDisplay1.Size = new System.Drawing.Size(14, 26);
            this.segmentDisplay1.TabIndex = 13;
            // 
            // Watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DigitalWatch.Properties.Resources.watch2;
            this.ClientSize = new System.Drawing.Size(300, 301);
            this.Controls.Add(this.segmentDisplay1);
            this.Controls.Add(this.lblAMPM);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.segmentDisplay4);
            this.Controls.Add(this.segmentDisplay3);
            this.Controls.Add(this.segmentDisplay2);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.btnModus);
            this.Name = "Watch";
            this.Text = "Digital Watch";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModus;
        private System.Windows.Forms.Button btnIncrement;
        private WindowsFormsControlLibrary1.SegmentDisplay segmentDisplay2;
        private WindowsFormsControlLibrary1.SegmentDisplay segmentDisplay3;
        private WindowsFormsControlLibrary1.SegmentDisplay segmentDisplay4;
        private System.Windows.Forms.Timer secondtimer;
        private System.Windows.Forms.Label lblColon;
        private System.Windows.Forms.Timer incrementtimer;
        private System.Windows.Forms.Label lblAMPM;
        private WindowsFormsControlLibrary1.SegmentDisplay segmentDisplay1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}

