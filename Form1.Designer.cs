namespace convo_test
{
    partial class wnd_Convo
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
            this.pb_ToInsert = new System.Windows.Forms.PictureBox();
            this.pb_BwImage = new System.Windows.Forms.PictureBox();
            this.pb_ConvoRes = new System.Windows.Forms.PictureBox();
            this.btn_Slash = new System.Windows.Forms.Button();
            this.btn_reverseSlash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_StraightLine = new System.Windows.Forms.Button();
            this.btn_HorizontalLine = new System.Windows.Forms.Button();
            this.btn_Star = new System.Windows.Forms.Button();
            this.pb_Blured = new System.Windows.Forms.PictureBox();
            this.btn_Cross = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ToInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BwImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ConvoRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Blured)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_ToInsert
            // 
            this.pb_ToInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_ToInsert.Location = new System.Drawing.Point(12, 12);
            this.pb_ToInsert.Name = "pb_ToInsert";
            this.pb_ToInsert.Size = new System.Drawing.Size(258, 272);
            this.pb_ToInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ToInsert.TabIndex = 0;
            this.pb_ToInsert.TabStop = false;
            // 
            // pb_BwImage
            // 
            this.pb_BwImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_BwImage.Location = new System.Drawing.Point(276, 12);
            this.pb_BwImage.Name = "pb_BwImage";
            this.pb_BwImage.Size = new System.Drawing.Size(258, 272);
            this.pb_BwImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_BwImage.TabIndex = 1;
            this.pb_BwImage.TabStop = false;
            // 
            // pb_ConvoRes
            // 
            this.pb_ConvoRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_ConvoRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_ConvoRes.Location = new System.Drawing.Point(804, 12);
            this.pb_ConvoRes.Name = "pb_ConvoRes";
            this.pb_ConvoRes.Size = new System.Drawing.Size(258, 272);
            this.pb_ConvoRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ConvoRes.TabIndex = 2;
            this.pb_ConvoRes.TabStop = false;
            // 
            // btn_Slash
            // 
            this.btn_Slash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Slash.Location = new System.Drawing.Point(8, 306);
            this.btn_Slash.Name = "btn_Slash";
            this.btn_Slash.Size = new System.Drawing.Size(75, 23);
            this.btn_Slash.TabIndex = 3;
            this.btn_Slash.Text = "/";
            this.btn_Slash.UseVisualStyleBackColor = true;
            this.btn_Slash.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_reverseSlash
            // 
            this.btn_reverseSlash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reverseSlash.Location = new System.Drawing.Point(8, 335);
            this.btn_reverseSlash.Name = "btn_reverseSlash";
            this.btn_reverseSlash.Size = new System.Drawing.Size(75, 23);
            this.btn_reverseSlash.TabIndex = 4;
            this.btn_reverseSlash.Text = "\\";
            this.btn_reverseSlash.UseVisualStyleBackColor = true;
            this.btn_reverseSlash.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Convolutional Filters";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_StraightLine
            // 
            this.btn_StraightLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_StraightLine.Location = new System.Drawing.Point(8, 364);
            this.btn_StraightLine.Name = "btn_StraightLine";
            this.btn_StraightLine.Size = new System.Drawing.Size(75, 23);
            this.btn_StraightLine.TabIndex = 6;
            this.btn_StraightLine.Text = "|";
            this.btn_StraightLine.UseVisualStyleBackColor = true;
            this.btn_StraightLine.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_HorizontalLine
            // 
            this.btn_HorizontalLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_HorizontalLine.Location = new System.Drawing.Point(8, 393);
            this.btn_HorizontalLine.Name = "btn_HorizontalLine";
            this.btn_HorizontalLine.Size = new System.Drawing.Size(75, 23);
            this.btn_HorizontalLine.TabIndex = 7;
            this.btn_HorizontalLine.Text = "-";
            this.btn_HorizontalLine.UseVisualStyleBackColor = true;
            this.btn_HorizontalLine.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Star
            // 
            this.btn_Star.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Star.Location = new System.Drawing.Point(89, 335);
            this.btn_Star.Name = "btn_Star";
            this.btn_Star.Size = new System.Drawing.Size(75, 23);
            this.btn_Star.TabIndex = 8;
            this.btn_Star.Text = "*";
            this.btn_Star.UseVisualStyleBackColor = true;
            this.btn_Star.Click += new System.EventHandler(this.btn_Click);
            // 
            // pb_Blured
            // 
            this.pb_Blured.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Blured.Location = new System.Drawing.Point(540, 12);
            this.pb_Blured.Name = "pb_Blured";
            this.pb_Blured.Size = new System.Drawing.Size(258, 272);
            this.pb_Blured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Blured.TabIndex = 9;
            this.pb_Blured.TabStop = false;
            // 
            // btn_Cross
            // 
            this.btn_Cross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cross.Location = new System.Drawing.Point(89, 306);
            this.btn_Cross.Name = "btn_Cross";
            this.btn_Cross.Size = new System.Drawing.Size(75, 23);
            this.btn_Cross.TabIndex = 10;
            this.btn_Cross.Text = "+";
            this.btn_Cross.UseVisualStyleBackColor = true;
            this.btn_Cross.Click += new System.EventHandler(this.btn_Click);
            // 
            // wnd_Convo
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 430);
            this.Controls.Add(this.btn_Cross);
            this.Controls.Add(this.pb_Blured);
            this.Controls.Add(this.btn_Star);
            this.Controls.Add(this.btn_HorizontalLine);
            this.Controls.Add(this.btn_StraightLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reverseSlash);
            this.Controls.Add(this.btn_Slash);
            this.Controls.Add(this.pb_ConvoRes);
            this.Controls.Add(this.pb_BwImage);
            this.Controls.Add(this.pb_ToInsert);
            this.MinimumSize = new System.Drawing.Size(1092, 469);
            this.Name = "wnd_Convo";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.pb_ToInsert_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.pb_ToInsert_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ToInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BwImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ConvoRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Blured)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ToInsert;
        private System.Windows.Forms.PictureBox pb_BwImage;
        private System.Windows.Forms.PictureBox pb_ConvoRes;
        private System.Windows.Forms.Button btn_Slash;
        private System.Windows.Forms.Button btn_reverseSlash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_StraightLine;
        private System.Windows.Forms.Button btn_HorizontalLine;
        private System.Windows.Forms.Button btn_Star;
        private System.Windows.Forms.PictureBox pb_Blured;
        private System.Windows.Forms.Button btn_Cross;
    }
}

