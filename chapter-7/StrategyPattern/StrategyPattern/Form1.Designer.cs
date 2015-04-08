namespace StrategyPattern
{
    partial class Form1
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
            this.bubbleSort = new System.Windows.Forms.Button();
            this.insertionSort = new System.Windows.Forms.Button();
            this.selectionSort = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.newArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bubbleSort
            // 
            this.bubbleSort.Location = new System.Drawing.Point(12, 12);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(85, 23);
            this.bubbleSort.TabIndex = 0;
            this.bubbleSort.Text = "BubbleSort";
            this.bubbleSort.UseVisualStyleBackColor = true;
            this.bubbleSort.Click += new System.EventHandler(this.ButtonClick);
            // 
            // insertionSort
            // 
            this.insertionSort.Location = new System.Drawing.Point(103, 12);
            this.insertionSort.Name = "insertionSort";
            this.insertionSort.Size = new System.Drawing.Size(85, 23);
            this.insertionSort.TabIndex = 1;
            this.insertionSort.Text = "InsertionSort";
            this.insertionSort.UseVisualStyleBackColor = true;
            this.insertionSort.Click += new System.EventHandler(this.ButtonClick);
            // 
            // selectionSort
            // 
            this.selectionSort.Location = new System.Drawing.Point(194, 12);
            this.selectionSort.Name = "selectionSort";
            this.selectionSort.Size = new System.Drawing.Size(85, 23);
            this.selectionSort.TabIndex = 2;
            this.selectionSort.Text = "SelectionSort";
            this.selectionSort.UseVisualStyleBackColor = true;
            this.selectionSort.Click += new System.EventHandler(this.ButtonClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 277);
            this.listBox1.TabIndex = 3;
            // 
            // newArray
            // 
            this.newArray.Location = new System.Drawing.Point(285, 12);
            this.newArray.Name = "newArray";
            this.newArray.Size = new System.Drawing.Size(85, 23);
            this.newArray.TabIndex = 4;
            this.newArray.Text = "New";
            this.newArray.UseVisualStyleBackColor = true;
            this.newArray.Click += new System.EventHandler(this.newArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 335);
            this.Controls.Add(this.newArray);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.selectionSort);
            this.Controls.Add(this.insertionSort);
            this.Controls.Add(this.bubbleSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bubbleSort;
        private System.Windows.Forms.Button insertionSort;
        private System.Windows.Forms.Button selectionSort;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button newArray;
    }
}

