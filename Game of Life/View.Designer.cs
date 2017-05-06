namespace Game_of_Life
{
    partial class View
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
            this.panelShow = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_blinker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_durchläufe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Margin = new System.Windows.Forms.Padding(0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(500, 500);
            this.panelShow.TabIndex = 0;
            this.panelShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelShow_Paint);
            this.panelShow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelShow_MouseMove);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(514, 62);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(93, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_blinker
            // 
            this.btn_blinker.Location = new System.Drawing.Point(514, 120);
            this.btn_blinker.Name = "btn_blinker";
            this.btn_blinker.Size = new System.Drawing.Size(93, 23);
            this.btn_blinker.TabIndex = 2;
            this.btn_blinker.Text = "Blinker";
            this.btn_blinker.UseVisualStyleBackColor = true;
            this.btn_blinker.Click += new System.EventHandler(this.btn_blinker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spieldurchläufe: ";
            // 
            // lbl_durchläufe
            // 
            this.lbl_durchläufe.AutoSize = true;
            this.lbl_durchläufe.Location = new System.Drawing.Point(603, 222);
            this.lbl_durchläufe.Name = "lbl_durchläufe";
            this.lbl_durchläufe.Size = new System.Drawing.Size(35, 13);
            this.lbl_durchläufe.TabIndex = 4;
            this.lbl_durchläufe.Text = "label2";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 500);
            this.Controls.Add(this.lbl_durchläufe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_blinker);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.panelShow);
            this.Name = "View";
            this.Text = "Game of Life";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_blinker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_durchläufe;
    }
}

