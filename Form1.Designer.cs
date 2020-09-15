namespace DeckOfCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSortByValue = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.picDrawn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.ForeColor = System.Drawing.Color.White;
            this.btnShuffle.Location = new System.Drawing.Point(70, 50);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(0);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(100, 30);
            this.btnShuffle.TabIndex = 0;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(210, 50);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 30);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort By Suit";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSortBySuit_Click);
            // 
            // btnSortByValue
            // 
            this.btnSortByValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSortByValue.FlatAppearance.BorderSize = 0;
            this.btnSortByValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortByValue.ForeColor = System.Drawing.Color.White;
            this.btnSortByValue.Location = new System.Drawing.Point(350, 50);
            this.btnSortByValue.Name = "btnSortByValue";
            this.btnSortByValue.Size = new System.Drawing.Size(100, 30);
            this.btnSortByValue.TabIndex = 2;
            this.btnSortByValue.Text = "Sort By Value";
            this.btnSortByValue.UseVisualStyleBackColor = false;
            this.btnSortByValue.Click += new System.EventHandler(this.btnSortByValue_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDraw.BackgroundImage")));
            this.btnDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDraw.Location = new System.Drawing.Point(210, 192);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(89, 122);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "Draw Card";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(220, 355);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(240, 40);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(490, 50);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Clear Table";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picDrawn
            // 
            this.picDrawn.Location = new System.Drawing.Point(362, 192);
            this.picDrawn.Name = "picDrawn";
            this.picDrawn.Size = new System.Drawing.Size(88, 122);
            this.picDrawn.TabIndex = 7;
            this.picDrawn.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(664, 461);
            this.Controls.Add(this.picDrawn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnSortByValue);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnShuffle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDrawn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSortByValue;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picDrawn;
    }
}

