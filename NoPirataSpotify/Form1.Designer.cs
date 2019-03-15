namespace NoPirataSpotify
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
            this.button_first = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_last = new System.Windows.Forms.Button();
            this.listBox_canciones = new System.Windows.Forms.ListBox();
            this.textBox_showMetadata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_first
            // 
            this.button_first.Location = new System.Drawing.Point(310, 247);
            this.button_first.Margin = new System.Windows.Forms.Padding(2);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(40, 34);
            this.button_first.TabIndex = 2;
            this.button_first.Text = "|<";
            this.button_first.UseVisualStyleBackColor = true;
            this.button_first.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 247);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 247);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_last
            // 
            this.button_last.Location = new System.Drawing.Point(442, 247);
            this.button_last.Margin = new System.Windows.Forms.Padding(2);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(40, 34);
            this.button_last.TabIndex = 5;
            this.button_last.Text = ">|";
            this.button_last.UseVisualStyleBackColor = true;
            this.button_last.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox_canciones
            // 
            this.listBox_canciones.FormattingEnabled = true;
            this.listBox_canciones.Location = new System.Drawing.Point(12, 12);
            this.listBox_canciones.Name = "listBox_canciones";
            this.listBox_canciones.Size = new System.Drawing.Size(271, 212);
            this.listBox_canciones.TabIndex = 6;
            this.listBox_canciones.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox_showMetadata
            // 
            this.textBox_showMetadata.Location = new System.Drawing.Point(306, 12);
            this.textBox_showMetadata.Multiline = true;
            this.textBox_showMetadata.Name = "textBox_showMetadata";
            this.textBox_showMetadata.Size = new System.Drawing.Size(171, 212);
            this.textBox_showMetadata.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 292);
            this.Controls.Add(this.textBox_showMetadata);
            this.Controls.Add(this.listBox_canciones);
            this.Controls.Add(this.button_last);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_first);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.ListBox listBox_canciones;
        private System.Windows.Forms.TextBox textBox_showMetadata;
    }
}

