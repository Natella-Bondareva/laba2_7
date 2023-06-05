namespace laba2_7
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
            this.components = new System.ComponentModel.Container();
            this.TaskA = new System.Windows.Forms.Button();
            this.TaskB = new System.Windows.Forms.Button();
            this.TaskC = new System.Windows.Forms.Button();
            this.TaskD = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskA
            // 
            this.TaskA.BackColor = System.Drawing.SystemColors.Control;
            this.TaskA.Location = new System.Drawing.Point(30, 391);
            this.TaskA.Name = "TaskA";
            this.TaskA.Size = new System.Drawing.Size(75, 23);
            this.TaskA.TabIndex = 0;
            this.TaskA.Text = "Task a";
            this.TaskA.UseVisualStyleBackColor = false;
            this.TaskA.Click += new System.EventHandler(this.TaskA_Click);
            // 
            // TaskB
            // 
            this.TaskB.BackColor = System.Drawing.SystemColors.Control;
            this.TaskB.Location = new System.Drawing.Point(158, 391);
            this.TaskB.Name = "TaskB";
            this.TaskB.Size = new System.Drawing.Size(75, 23);
            this.TaskB.TabIndex = 1;
            this.TaskB.Text = "Task b";
            this.TaskB.UseVisualStyleBackColor = false;
            this.TaskB.Click += new System.EventHandler(this.TaskB_Click);
            // 
            // TaskC
            // 
            this.TaskC.BackColor = System.Drawing.SystemColors.Control;
            this.TaskC.Location = new System.Drawing.Point(279, 391);
            this.TaskC.Name = "TaskC";
            this.TaskC.Size = new System.Drawing.Size(75, 23);
            this.TaskC.TabIndex = 2;
            this.TaskC.Text = "Task c";
            this.TaskC.UseVisualStyleBackColor = false;
            this.TaskC.Click += new System.EventHandler(this.TaskC_Click);
            // 
            // TaskD
            // 
            this.TaskD.BackColor = System.Drawing.SystemColors.Control;
            this.TaskD.Location = new System.Drawing.Point(403, 391);
            this.TaskD.Name = "TaskD";
            this.TaskD.Size = new System.Drawing.Size(75, 23);
            this.TaskD.TabIndex = 3;
            this.TaskD.Text = "Task d";
            this.TaskD.UseVisualStyleBackColor = false;
            this.TaskD.Click += new System.EventHandler(this.TaskD_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.Control;
            this.Close.Location = new System.Drawing.Point(682, 391);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(64, 29);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(596, 335);
            this.pic.TabIndex = 5;
            this.pic.TabStop = false;
            this.pic.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.TaskD);
            this.Controls.Add(this.TaskC);
            this.Controls.Add(this.TaskB);
            this.Controls.Add(this.TaskA);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TaskA;
        private System.Windows.Forms.Button TaskB;
        private System.Windows.Forms.Button TaskC;
        private System.Windows.Forms.Button TaskD;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pic;
    }
}

