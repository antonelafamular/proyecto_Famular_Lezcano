namespace proyecto_Famular_Lezcano
{
    partial class FormMain
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
            PanelContent = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            PanelMenu = new Panel();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // PanelContent
            // 
            PanelContent.BackColor = SystemColors.ActiveBorder;
            PanelContent.Location = new Point(150, 0);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(636, 500);
            PanelContent.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Info;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(150, 100);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Desktop;
            pictureBox1.Location = new Point(0, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 100);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonFace;
            pictureBox2.Location = new Point(0, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 100);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDark;
            pictureBox3.Location = new Point(0, 300);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 100);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = SystemColors.ActiveCaption;
            PanelMenu.Controls.Add(pictureBox4);
            PanelMenu.Controls.Add(pictureBox3);
            PanelMenu.Controls.Add(pictureBox2);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(pictureBox5);
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(150, 500);
            PanelMenu.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ControlLight;
            pictureBox4.Location = new Point(0, 400);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 100);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 486);
            Controls.Add(PanelContent);
            Controls.Add(PanelMenu);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelContent;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel PanelMenu;
        private PictureBox pictureBox4;
    }
}
