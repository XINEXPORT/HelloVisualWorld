namespace HelloVisualWorld
{
    partial class HelloForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            displayOutputButton = new Button();
            helloLabel = new Label();
            changeOutputButton = new Button();
            SuspendLayout();
            // 
            // displayOutputButton
            // 
            displayOutputButton.Location = new Point(80, 50);
            displayOutputButton.Name = "displayOutputButton";
            displayOutputButton.Size = new Size(120, 57);
            displayOutputButton.TabIndex = 0;
            displayOutputButton.Text = "Click here";
            displayOutputButton.UseVisualStyleBackColor = true;
            displayOutputButton.Click += DisplayOutputButton_Click;
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.BackColor = Color.Black;
            helloLabel.Font = new Font("Liquidism", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helloLabel.ForeColor = Color.Lime;
            helloLabel.Location = new Point(80, 140);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(561, 36);
            helloLabel.TabIndex = 1;
            helloLabel.Text = "Hello, Visual World!";
            helloLabel.Visible = false;
            helloLabel.Click += helloLabel_Click;
            // 
            // changeOutputButton
            // 
            changeOutputButton.Enabled = false;
            changeOutputButton.Location = new Point(80, 195);
            changeOutputButton.Name = "changeOutputButton";
            changeOutputButton.Size = new Size(102, 57);
            changeOutputButton.TabIndex = 2;
            changeOutputButton.Text = "Click me last";
            changeOutputButton.UseVisualStyleBackColor = true;
            changeOutputButton.Click += ChangeOutputButton_Click;
            // 
            // HelloForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(changeOutputButton);
            Controls.Add(helloLabel);
            Controls.Add(displayOutputButton);
            Name = "HelloForm";
            Text = "Hello Christine' Visual World";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button displayOutputButton;
        private Label helloLabel;
        private Button changeOutputButton;
    }
}
