namespace Timer_demo
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
            this.Countlable = new System.Windows.Forms.Label();
            this.colorlable = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.counttimer = new System.Windows.Forms.Timer(this.components);
            this.timelable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Countlable
            // 
            this.Countlable.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countlable.Location = new System.Drawing.Point(292, 78);
            this.Countlable.Name = "Countlable";
            this.Countlable.Size = new System.Drawing.Size(114, 34);
            this.Countlable.TabIndex = 0;
            this.Countlable.Text = "label1";
            this.Countlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorlable
            // 
            this.colorlable.BackColor = System.Drawing.Color.White;
            this.colorlable.Location = new System.Drawing.Point(309, 127);
            this.colorlable.Name = "colorlable";
            this.colorlable.Size = new System.Drawing.Size(78, 59);
            this.colorlable.TabIndex = 1;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(312, 205);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // counttimer
            // 
            this.counttimer.Interval = 500;
            this.counttimer.Tick += new System.EventHandler(this.counttimer_Tick);
            // 
            // timelable
            // 
            this.timelable.Location = new System.Drawing.Point(295, 267);
            this.timelable.Name = "timelable";
            this.timelable.Size = new System.Drawing.Size(100, 23);
            this.timelable.TabIndex = 3;
            this.timelable.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timelable);
            this.Controls.Add(this.start);
            this.Controls.Add(this.colorlable);
            this.Controls.Add(this.Countlable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Countlable;
        private System.Windows.Forms.Label colorlable;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer counttimer;
        private System.Windows.Forms.Label timelable;
    }
}

