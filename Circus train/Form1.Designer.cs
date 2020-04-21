namespace Circus_train
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Generatebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.GenerateTrainBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AnimalCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalCount)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(501, 32);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(287, 406);
            this.treeView1.TabIndex = 0;
            // 
            // Generatebtn
            // 
            this.Generatebtn.Location = new System.Drawing.Point(329, 32);
            this.Generatebtn.Name = "Generatebtn";
            this.Generatebtn.Size = new System.Drawing.Size(145, 42);
            this.Generatebtn.TabIndex = 1;
            this.Generatebtn.Text = "Generate Animals";
            this.Generatebtn.UseVisualStyleBackColor = true;
            this.Generatebtn.Click += new System.EventHandler(this.GenerateAnimalsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Circus animals";
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(12, 32);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(287, 406);
            this.treeView2.TabIndex = 3;
            // 
            // GenerateTrainBtn
            // 
            this.GenerateTrainBtn.Location = new System.Drawing.Point(329, 80);
            this.GenerateTrainBtn.Name = "GenerateTrainBtn";
            this.GenerateTrainBtn.Size = new System.Drawing.Size(145, 47);
            this.GenerateTrainBtn.TabIndex = 4;
            this.GenerateTrainBtn.Text = "Fill the train wagons";
            this.GenerateTrainBtn.UseVisualStyleBackColor = true;
            this.GenerateTrainBtn.Click += new System.EventHandler(this.GenerateTrainBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Train wagons";
            // 
            // AnimalCount
            // 
            this.AnimalCount.Location = new System.Drawing.Point(407, 146);
            this.AnimalCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.AnimalCount.Name = "AnimalCount";
            this.AnimalCount.Size = new System.Drawing.Size(67, 20);
            this.AnimalCount.TabIndex = 6;
            this.AnimalCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Animal Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnimalCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenerateTrainBtn);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generatebtn);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Animal Circus";
            ((System.ComponentModel.ISupportInitialize)(this.AnimalCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button Generatebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button GenerateTrainBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AnimalCount;
        private System.Windows.Forms.Label label3;
    }
}

