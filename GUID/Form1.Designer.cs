
namespace GUID
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ids_listbox = new System.Windows.Forms.ListBox();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.generate_button = new System.Windows.Forms.Button();
            this.length_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ids_listbox
            // 
            this.ids_listbox.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ids_listbox.FormattingEnabled = true;
            this.ids_listbox.ItemHeight = 30;
            this.ids_listbox.Location = new System.Drawing.Point(12, 44);
            this.ids_listbox.Name = "ids_listbox";
            this.ids_listbox.Size = new System.Drawing.Size(347, 364);
            this.ids_listbox.TabIndex = 0;
            // 
            // amount_textbox
            // 
            this.amount_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amount_textbox.Location = new System.Drawing.Point(166, 12);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(33, 30);
            this.amount_textbox.TabIndex = 1;
            // 
            // generate_button
            // 
            this.generate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.generate_button.Location = new System.Drawing.Point(205, 12);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(154, 30);
            this.generate_button.TabIndex = 2;
            this.generate_button.Text = "adet ID oluştur!";
            this.generate_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // length_textbox
            // 
            this.length_textbox.Location = new System.Drawing.Point(12, 12);
            this.length_textbox.Multiline = true;
            this.length_textbox.Name = "length_textbox";
            this.length_textbox.Size = new System.Drawing.Size(33, 30);
            this.length_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "karakterlik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.length_textbox);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.ids_listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ids_listbox;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.TextBox length_textbox;
        private System.Windows.Forms.Label label1;
    }
}

