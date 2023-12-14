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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.60298F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.47146F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_info, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbx_coder_in, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbx_coder_out, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbx_errors, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbx_decoder_in, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbx_decoder_out, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.3886F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.54404F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 577);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(485, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decoder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(324, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Channel";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_info
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbx_info, 4);
            this.tbx_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_info.Location = new System.Drawing.Point(2, 200);
            this.tbx_info.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_info.Multiline = true;
            this.tbx_info.Name = "tbx_info";
            this.tbx_info.ReadOnly = true;
            this.tbx_info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_info.Size = new System.Drawing.Size(636, 375);
            this.tbx_info.TabIndex = 3;
            // 
            // tbx_coder_in
            // 
            this.tbx_coder_in.AcceptsTab = true;
            this.tbx_coder_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_coder_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_coder_in.Location = new System.Drawing.Point(2, 54);
            this.tbx_coder_in.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_coder_in.MaxLength = 39;
            this.tbx_coder_in.Multiline = true;
            this.tbx_coder_in.Name = "tbx_coder_in";
            this.tbx_coder_in.Size = new System.Drawing.Size(157, 142);
            this.tbx_coder_in.TabIndex = 5;
            this.tbx_coder_in.Text = "100100100111100011101111010000101101101";
            // 
            // tbx_coder_out
            // 
            this.tbx_coder_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_coder_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_coder_out.Location = new System.Drawing.Point(163, 54);
            this.tbx_coder_out.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_coder_out.Multiline = true;
            this.tbx_coder_out.Name = "tbx_coder_out";
            this.tbx_coder_out.ReadOnly = true;
            this.tbx_coder_out.Size = new System.Drawing.Size(157, 142);
            this.tbx_coder_out.TabIndex = 5;
            this.tbx_coder_out.Text = "100100100";
            // 
            // tbx_errors
            // 
            this.tbx_errors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_errors.Location = new System.Drawing.Point(324, 54);
            this.tbx_errors.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_errors.Multiline = true;
            this.tbx_errors.Name = "tbx_errors";
            this.tbx_errors.ReadOnly = true;
            this.tbx_errors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_errors.Size = new System.Drawing.Size(157, 142);
            this.tbx_errors.TabIndex = 5;
            this.tbx_errors.Text = "errors bits:";
            // 
            // tbx_decoder_in
            // 
            this.tbx_decoder_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_decoder_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_decoder_in.Location = new System.Drawing.Point(485, 54);
            this.tbx_decoder_in.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_decoder_in.Multiline = true;
            this.tbx_decoder_in.Name = "tbx_decoder_in";
            this.tbx_decoder_in.ReadOnly = true;
            this.tbx_decoder_in.Size = new System.Drawing.Size(153, 142);
            this.tbx_decoder_in.TabIndex = 5;
            this.tbx_decoder_in.Text = "100100100";
            // 
            // tbx_decoder_out
            // 
            this.tbx_decoder_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_decoder_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_decoder_out.Location = new System.Drawing.Point(642, 54);
            this.tbx_decoder_out.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_decoder_out.Multiline = true;
            this.tbx_decoder_out.Name = "tbx_decoder_out";
            this.tbx_decoder_out.ReadOnly = true;
            this.tbx_decoder_out.Size = new System.Drawing.Size(162, 142);
            this.tbx_decoder_out.TabIndex = 5;
            this.tbx_decoder_out.Text = "100100100";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(642, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 375);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 577);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "BCH code";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_info;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_coder_in;
        private System.Windows.Forms.TextBox tbx_coder_out;
        private System.Windows.Forms.TextBox tbx_errors;
        private System.Windows.Forms.TextBox tbx_decoder_in;
        private System.Windows.Forms.TextBox tbx_decoder_out;
    }
}

