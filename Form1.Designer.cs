namespace CycleCode
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_info = new System.Windows.Forms.TextBox();
            this.tbx_coder_in = new System.Windows.Forms.TextBox();
            this.tbx_coder_out = new System.Windows.Forms.TextBox();
            this.tbx_errors = new System.Windows.Forms.TextBox();
            this.tbx_decoder_in = new System.Windows.Forms.TextBox();
            this.tbx_decoder_out = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Coder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(648, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Decoder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(453, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Channel";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_info
            // 
            this.tbx_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_info.Location = new System.Drawing.Point(7, 237);
            this.tbx_info.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_info.Multiline = true;
            this.tbx_info.Name = "tbx_info";
            this.tbx_info.ReadOnly = true;
            this.tbx_info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_info.Size = new System.Drawing.Size(976, 302);
            this.tbx_info.TabIndex = 9;
            // 
            // tbx_coder_in
            // 
            this.tbx_coder_in.AcceptsTab = true;
            this.tbx_coder_in.BackColor = System.Drawing.Color.White;
            this.tbx_coder_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_coder_in.Location = new System.Drawing.Point(7, 94);
            this.tbx_coder_in.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_coder_in.MaxLength = 39;
            this.tbx_coder_in.Multiline = true;
            this.tbx_coder_in.Name = "tbx_coder_in";
            this.tbx_coder_in.Size = new System.Drawing.Size(193, 139);
            this.tbx_coder_in.TabIndex = 11;
            this.tbx_coder_in.Text = "100100100111100011101111010000101101101";
            // 
            // tbx_coder_out
            // 
            this.tbx_coder_out.BackColor = System.Drawing.Color.White;
            this.tbx_coder_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_coder_out.Location = new System.Drawing.Point(204, 94);
            this.tbx_coder_out.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_coder_out.Multiline = true;
            this.tbx_coder_out.Name = "tbx_coder_out";
            this.tbx_coder_out.ReadOnly = true;
            this.tbx_coder_out.Size = new System.Drawing.Size(193, 139);
            this.tbx_coder_out.TabIndex = 12;
            this.tbx_coder_out.Text = "100100100";
            // 
            // tbx_errors
            // 
            this.tbx_errors.BackColor = System.Drawing.Color.White;
            this.tbx_errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_errors.Location = new System.Drawing.Point(401, 94);
            this.tbx_errors.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_errors.Multiline = true;
            this.tbx_errors.Name = "tbx_errors";
            this.tbx_errors.ReadOnly = true;
            this.tbx_errors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_errors.Size = new System.Drawing.Size(193, 139);
            this.tbx_errors.TabIndex = 13;
            this.tbx_errors.Text = "errors bits:";
            // 
            // tbx_decoder_in
            // 
            this.tbx_decoder_in.BackColor = System.Drawing.Color.White;
            this.tbx_decoder_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_decoder_in.Location = new System.Drawing.Point(598, 94);
            this.tbx_decoder_in.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_decoder_in.Multiline = true;
            this.tbx_decoder_in.Name = "tbx_decoder_in";
            this.tbx_decoder_in.ReadOnly = true;
            this.tbx_decoder_in.Size = new System.Drawing.Size(193, 139);
            this.tbx_decoder_in.TabIndex = 14;
            this.tbx_decoder_in.Text = "100100100";
            // 
            // tbx_decoder_out
            // 
            this.tbx_decoder_out.BackColor = System.Drawing.Color.White;
            this.tbx_decoder_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_decoder_out.Location = new System.Drawing.Point(795, 94);
            this.tbx_decoder_out.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_decoder_out.Multiline = true;
            this.tbx_decoder_out.Name = "tbx_decoder_out";
            this.tbx_decoder_out.ReadOnly = true;
            this.tbx_decoder_out.Size = new System.Drawing.Size(188, 139);
            this.tbx_decoder_out.TabIndex = 15;
            this.tbx_decoder_out.Text = "100100100";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(7, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(976, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(843, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Decoder";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(258, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Coder";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 542);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_info);
            this.Controls.Add(this.tbx_coder_in);
            this.Controls.Add(this.tbx_coder_out);
            this.Controls.Add(this.tbx_errors);
            this.Controls.Add(this.tbx_decoder_in);
            this.Controls.Add(this.tbx_decoder_out);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "BCH code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_info;
        private System.Windows.Forms.TextBox tbx_coder_in;
        private System.Windows.Forms.TextBox tbx_coder_out;
        private System.Windows.Forms.TextBox tbx_errors;
        private System.Windows.Forms.TextBox tbx_decoder_in;
        private System.Windows.Forms.TextBox tbx_decoder_out;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

