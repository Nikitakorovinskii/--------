
namespace Каршеринг
{
    partial class Dogovor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dogovor));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.carrentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrentDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelNumberContract = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Договор  №-";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(308, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(876, 361);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // labelNumberContract
            // 
            this.labelNumberContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberContract.Location = new System.Drawing.Point(487, 9);
            this.labelNumberContract.Name = "labelNumberContract";
            this.labelNumberContract.Size = new System.Drawing.Size(271, 47);
            this.labelNumberContract.TabIndex = 3;
            // 
            // Dogovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 518);
            this.Controls.Add(this.labelNumberContract);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Dogovor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dogovor";
            this.Load += new System.EventHandler(this.Dogovor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource carrentDataSetBindingSource;
        private System.Windows.Forms.BindingSource carrentDataSetBindingSource1;
        private System.Windows.Forms.Label labelNumberContract;
    }
}