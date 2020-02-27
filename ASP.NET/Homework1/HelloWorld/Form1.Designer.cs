namespace HelloWorld
{
    partial class FormHelloWorld
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
            this.butHello = new System.Windows.Forms.Button();
            this.butGoodbye = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butHello
            // 
            this.butHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.butHello.Location = new System.Drawing.Point(12, 47);
            this.butHello.Name = "butHello";
            this.butHello.Size = new System.Drawing.Size(102, 31);
            this.butHello.TabIndex = 0;
            this.butHello.Text = "Hello";
            this.butHello.UseVisualStyleBackColor = true;
            this.butHello.Click += new System.EventHandler(this.butHello_Click);
            // 
            // butGoodbye
            // 
            this.butGoodbye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.butGoodbye.Location = new System.Drawing.Point(120, 47);
            this.butGoodbye.Name = "butGoodbye";
            this.butGoodbye.Size = new System.Drawing.Size(102, 31);
            this.butGoodbye.TabIndex = 1;
            this.butGoodbye.Text = "Goodbye";
            this.butGoodbye.UseVisualStyleBackColor = true;
            this.butGoodbye.Click += new System.EventHandler(this.butGoodbye_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtOutput.Location = new System.Drawing.Point(12, 12);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(210, 29);
            this.txtOutput.TabIndex = 2;
            // 
            // FormHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 86);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.butGoodbye);
            this.Controls.Add(this.butHello);
            this.Name = "FormHelloWorld";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butHello;
        private System.Windows.Forms.Button butGoodbye;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

